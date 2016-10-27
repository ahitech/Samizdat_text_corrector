using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Text_corrector
{

    public partial class MainWindow : Form
    {
        Dictionary<Char, String> dictionary = new Dictionary<Char, String>();
        Dictionary<string, string> replacee = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictionary.Add ('«', "&#0171;");
            dictionary.Add ('»', "&#0187;");
            dictionary.Add ('…', "&#0133;");
            dictionary.Add ('°', "&#0176;");
            dictionary.Add ('„', "&#0132;");
            dictionary.Add ('”', "&#0148;");
            dictionary.Add ('“', "&#0147;");
            dictionary.Add ('•', "&#0149;");
            dictionary.Add ('©', "&#0169;");
            dictionary.Add ('™', "&#0153;");
            dictionary.Add ('®', "&#0174;");
            dictionary.Add ('†', "&#0134;");
            dictionary.Add ('‡', "&#0135;");
            dictionary.Add ('±', "&#0177;");
            dictionary.Add ('§', "&#0167;");
            dictionary.Add ('№', "&#8470;");
            dictionary.Add ('×', "&#0215;");  // Times sign
            dictionary.Add ('∙', "&#8729;");  // Multiplication dot
            dictionary.Add ('⋅', "&#8901;");  // Another multiplication dot
            dictionary.Add ('•', "&#8226;");  // Bullet

            replacee.Add(" — ", "&#0160;&#0151; ");
            replacee.Add(" – ", "&#0160;&#0150; ");
            replacee.Add("— ", "&#0151;&#0160;");
            replacee.Add("– ", "&#0150;&#0160;");

            // Next line corrects the separator, which is three asterisks in form of *   *   *
            replacee.Add("<P[^>]*>\\s*(?<separator>\\*(&nbsp;)*\\s+\\*(&nbsp;)*\\s+\\*)\\s*(?<new_text>.*)</P>", "<P align=center>${separator} ${new_text}</P>");
            replacee.Add(@"about:(\s)*blank", "");
            replacee.Add(@"<P[^>]*>(\s?)</P>", "");
//            replacee.Add("<P[^>]*>(\\s*<B>\\s*)?(?<separator>\\*(&nbsp;)*\\s+\\*(&nbsp;)*\\s+\\*)(\\s*<B>\\s*)?\\s*(?<new_text>\\w+\\s+\\d+\\W\\d+\\W\\d+\\s*)(\\s*</B>\\s*)?</P>", "<P align=center>${separator}&#0160;<B>${new_text}</B></P>");

            replacee.Add("<href", "<a href");


            // On-load modifications
            this.AlignmentListBox.SelectedIndex = 3;
            this.AlignmentListBox.SelectedIndexChanged += new System.EventHandler(this.TextWidthTextBox_Changed);
            this.SurroundWithTable_CheckedChanged(sender, e);
            this.Convert_button.Click += new System.EventHandler(this.CleanupButton_Click);
            this.startFootnotesFrom.Text = "1";
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            this.RemoveBlankLinesCheckBox.CheckedChanged += new System.EventHandler(this.RemoveBlankLinesCheckBox_CheckedChanged);
            this.TextWidthTextBox.TextChanged += new System.EventHandler(this.TextWidthTextBox_Changed);
            this.SurroundTable.CheckedChanged += new System.EventHandler(this.SurroundWithTable_CheckedChanged);
            this.AmountOfSpaces.Text = "2";
            this.AmountOfSpaces.TextChanged += new System.EventHandler(this.AmountOfSpaces_Changed);
            this.ParagraphsSpacing.CheckedChanged += new System.EventHandler(this.ParagraphSpacing_CheckedChanged);
            this.CorrectFootnotesButton.Click += new System.EventHandler(this.CorrectFootnotesButton_Click);
        }

        private int footnoteNumber = 0;
        private string evaluator1 (Match match)
        {
            StringBuilder sb = new StringBuilder();
            int count1 = int.Parse(match.Groups["count1"].Value);
            int count2 = int.Parse(match.Groups["count2"].Value);
            int count3 = int.Parse(match.Groups["count3"].Value);

            sb.Append("<A title=\"\" href=\"#_ftn");
            sb.Append(footnoteNumber);
            sb.Append("\" name=_ftnref");
            sb.Append(footnoteNumber);
            sb.Append(">[").Append(footnoteNumber).Append("]</A>");
            footnoteNumber++;

            return sb.ToString();
        }

        private string evaluator2(Match match)
        {
            StringBuilder sb = new StringBuilder();

            int count1 = int.Parse(match.Groups["count1"].Value);
            int count2 = int.Parse(match.Groups["count2"].Value);
            int count3 = int.Parse(match.Groups["count3"].Value);

            sb.Append("<A title=\"\" href=\"#_ftnref");
            sb.Append(footnoteNumber);
            sb.Append("\" name=_ftn");
            sb.Append(footnoteNumber);
            sb.Append(">[").Append(footnoteNumber).Append("]</A>");
            footnoteNumber++;

            return sb.ToString();
        }

        private String CleanupHTMLText(String input)
        {
            
            Dictionary<string, string> regexp = new Dictionary<string,string>()
            {
                {"&#0160;", " "},
                {"\\s{2,}", " "},
                {"<SPAN [^>]+>", ""},
                {"</SPAN>", ""},
                {"<FONT [^>]+>", ""},
                {"</FONT>", ""},
                {"<DIV [^>]+>", ""},
                {"</DIV>", ""},
                {"<BR [^>]+>", ""},
                {" style=\"[^\"]+\"", ""},
                {@"<\?xml:[^>]+>", ""},
                {"<[/]?o:p>", ""},
                {@"(\s+)J(\s?)", "${1}&#x263A;"},   // Смайлик
                {" class=[^>]+>", ">"},
//                {@"<P[^>]*>(?<separator>\\*(&nbsp;)*\\s+\\*(&nbsp;)*\\s+\\*)(?<new_text>.*)</P>", "<P align=center>${separator} ${new_text}</P>"},
                {@"<P[^>]*>(\s?)</P>", ""},
                {@"about:(\s)*blank", ""},
                {@"</P>(?<text>\\[^\\s+\\])", "</P>\r\n\r\n${text}"},

            };

            foreach (KeyValuePair<string, string> replacement in regexp)
            {
                Regex reg = new Regex (replacement.Key, RegexOptions.IgnoreCase);
                input = reg.Replace (input, replacement.Value);
            }

            return (input);
        }

        private void CorrectFootnotes()
        {
            int temp;
            try
            {
                if (startFootnotesFrom.Text.Length > 0)
                    footnoteNumber = System.Int32.Parse(startFootnotesFrom.Text);
            }
            catch (Exception)
            {
                footnoteNumber = 1;
            }
            temp = footnoteNumber;
            String input = OutputBox.Text;

            /* Correcting the footnotes */
            input = Regex.Replace(input,
                                  "<A \\S+ href=\"#_ftn(?<count1>\\d+)\" name=_ftnref(?<count2>\\d+)>\\[(?<count3>\\d+)\\]</A>",
                                  evaluator1);
            footnoteNumber = temp;
            input = Regex.Replace(input,
                                  "<A \\S+ href=\"#_ftnref(?<count1>\\d+)\" name=_ftn(?<count2>\\d+)>\\[(?<count3>\\d+)\\]</A>",
                                  evaluator2);

            OutputBox.Text = input;
        }

        private String ReplaceText(String input)
        {
            foreach (KeyValuePair<string, string> replacement in replacee)
            {
                input = Regex.Replace(input, replacement.Key, replacement.Value, RegexOptions.IgnoreCase);
            }

            return (input);
        }

        private void CleanupButton_Click(object sender, EventArgs e)
        {
            String input = inputBox.Text;
            String output = "";

            input = CleanupHTMLText(input);

            for (int i = 0, limit = input.Length; i < limit; i++)
            {
                Char c = input[i];
                if (dictionary.ContainsKey(c)) 
                {
                    output += dictionary[c];
                }
                else
                {
                    output += c;
                }
            }
            output += "";

            output = ReplaceText(output);

            OutputBox.Text = output;
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            this.inputBox.InputBox_Paste();
        }

        private void RemoveBlankLinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            String input = OutputBox.Text;
            if (RemoveBlankLinesCheckBox.Checked)
            {
                input = input.Replace("\n", @"<!-- new line //-->");
            }
            else
            {
                input = input.Replace(@"<!-- new line //-->", "\n");
            }
            OutputBox.Text = input;
        }

        private void ParagraphSpacing_CheckedChanged(object sender, EventArgs e)
        {
            if (ParagraphsSpacing.Checked == true)
            {
                // Enable the spacer
                AmountOfSpaces.Enabled = true;
                SpacingAtParagraphStart.Enabled = true;
                AmountOfSpaces_Changed(sender, e);
            }
            else
            {
                AmountOfSpaces.Enabled = false;
                SpacingAtParagraphStart.Enabled = false;
                AmountOfSpaces_Update(0);
            }
        }

        private void AmountOfSpaces_Changed(object sender, EventArgs e)
        {
            int i;
            if (this.AmountOfSpaces.Text.Length > 0) {
                i = int.Parse(this.AmountOfSpaces.Text);
            } else {
                i = 0;
            }
            AmountOfSpaces_Update(i);
        }

        private void AmountOfSpaces_Update(int numberOfSpaces)
        {
            string template = @"<P>";
            for (int i = 0; i < numberOfSpaces; i++)
            {
                template += @"&#0160;";
            }
            Regex reg = new Regex("<P>(\\&#0160;)*", RegexOptions.IgnoreCase);
            String output = reg.Replace(OutputBox.Text, template);
            OutputBox.Text = output;
        }

        private void SurroundWithTable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SurroundTable.Checked == true)
            {
                // Enable the controls
                TextWidth.Enabled = true;
                TextWidthTextBox.Enabled = true;
                AlignmentLabel.Enabled = true;
                AlignmentListBox.Enabled = true;
                TextWidthTextBox_CreateTable();
            }
            else
            {
                TextWidth.Enabled = false;
                TextWidthTextBox.Enabled = false;
                AlignmentLabel.Enabled = false;
                AlignmentListBox.Enabled = false;
                TextWidthTextBox_RemoveTable();
            }
        }

        private void TextWidthTextBox_Changed(object sender, EventArgs e)
        {
            TextWidthTextBox_RemoveTable();
            TextWidthTextBox_CreateTable();
        }

        private void TextWidthTextBox_CreateTable () {
            int width;
            try {
                width = int.Parse(TextWidthTextBox.Text);
            } catch (Exception ) {
                width = 100;
            }
            string alignment = TextWidthTextBox_GetAligment();
            String output = @"<table width=" + width + @"% align=center border=0 cellpadding=1 cellspacing=0>"
                + @"<tr><td align=" + alignment + @">" + OutputBox.Text + @"</td></tr></table>";
            OutputBox.Text = output;
        }

        private void TextWidthTextBox_RemoveTable () {
            Regex reg = new Regex ("<table width=\\d{1,3}\\% align=center border=0 cellpadding=1 cellspacing=0>"
                + "<tr><td align=\\w+\\>");
            String output = OutputBox.Text;
            output = reg.Replace(output, "");
            reg = new Regex ("</td></tr></table>");
            output = reg.Replace(output, "");
            OutputBox.Text = output;
        }

        private string TextWidthTextBox_GetAligment()
        {
            switch (AlignmentListBox.SelectedIndex) {
                case 0: 
                    return "left";
                case 1:
                    return "center";
                case 2:
                    return "right";
                default:
                    return "justify";
            };
        }

        private void CorrectFootnotesButton_Click(object sender, EventArgs e)
        {
            this.CorrectFootnotes();
        }

        private void SendToTypografButton_Click(object sender, EventArgs e)
        {
            ArtLebedevStudio.RemoteTypograf remoteTypograf = new ArtLebedevStudio.RemoteTypograf();

            remoteTypograf.xmlEntities();
            remoteTypograf.br(true);
            remoteTypograf.p(true);
            remoteTypograf.nobr(3);

            inputBox.Text = remoteTypograf.ProcessText(inputBox.Text);
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            PreviewPane preview = new PreviewPane(this);
            preview.Show();
        }
    }
}
