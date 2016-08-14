namespace Text_corrector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.Convert_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startFootnotesFrom = new System.Windows.Forms.MaskedTextBox();
            this.pasteButton = new System.Windows.Forms.Button();
            this.RemoveBlankLinesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AlignmentListBox = new System.Windows.Forms.ComboBox();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.TextWidthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TextWidth = new System.Windows.Forms.Label();
            this.SurroundTable = new System.Windows.Forms.CheckBox();
            this.AmountOfSpaces = new System.Windows.Forms.MaskedTextBox();
            this.SpacingAtParagraphStart = new System.Windows.Forms.Label();
            this.ParagraphsSpacing = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.AutoWordSelection = true;
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputBox.Location = new System.Drawing.Point(3, 16);
            this.InputBox.Margin = new System.Windows.Forms.Padding(5);
            this.InputBox.MinimumSize = new System.Drawing.Size(4, 100);
            this.InputBox.Name = "InputBox";
            this.InputBox.ShowSelectionMargin = true;
            this.InputBox.Size = new System.Drawing.Size(986, 186);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "";
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.groupBox1.MaximumSize = new System.Drawing.Size(0, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTML, скопированный из Ворда";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 430);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат чистки";
            // 
            // OutputBox
            // 
            this.OutputBox.CausesValidation = false;
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.HideSelection = false;
            this.OutputBox.Location = new System.Drawing.Point(3, 16);
            this.OutputBox.MaxLength = 0;
            this.OutputBox.MinimumSize = new System.Drawing.Size(300, 4);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(742, 411);
            this.OutputBox.TabIndex = 0;
            // 
            // Convert_button
            // 
            this.Convert_button.Image = ((System.Drawing.Image)(resources.GetObject("Convert_button.Image")));
            this.Convert_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Convert_button.Location = new System.Drawing.Point(216, 213);
            this.Convert_button.Margin = new System.Windows.Forms.Padding(10);
            this.Convert_button.MinimumSize = new System.Drawing.Size(100, 40);
            this.Convert_button.Name = "Convert_button";
            this.Convert_button.Padding = new System.Windows.Forms.Padding(5);
            this.Convert_button.Size = new System.Drawing.Size(196, 50);
            this.Convert_button.TabIndex = 3;
            this.Convert_button.Text = "ЧИСТКА!";
            this.Convert_button.UseVisualStyleBackColor = true;
            this.Convert_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сноски начинаются с:";
            // 
            // startFootnotesFrom
            // 
            this.startFootnotesFrom.Location = new System.Drawing.Point(176, 23);
            this.startFootnotesFrom.Mask = "00000";
            this.startFootnotesFrom.Name = "startFootnotesFrom";
            this.startFootnotesFrom.Size = new System.Drawing.Size(51, 20);
            this.startFootnotesFrom.TabIndex = 7;
            this.startFootnotesFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.startFootnotesFrom.ValidatingType = typeof(int);
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(15, 213);
            this.pasteButton.Margin = new System.Windows.Forms.Padding(10);
            this.pasteButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Padding = new System.Windows.Forms.Padding(5);
            this.pasteButton.Size = new System.Drawing.Size(196, 50);
            this.pasteButton.TabIndex = 8;
            this.pasteButton.Text = "Выполнить копирование из Word";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // RemoveBlankLinesCheckBox
            // 
            this.RemoveBlankLinesCheckBox.AutoSize = true;
            this.RemoveBlankLinesCheckBox.Location = new System.Drawing.Point(9, 48);
            this.RemoveBlankLinesCheckBox.Name = "RemoveBlankLinesCheckBox";
            this.RemoveBlankLinesCheckBox.Size = new System.Drawing.Size(146, 17);
            this.RemoveBlankLinesCheckBox.TabIndex = 9;
            this.RemoveBlankLinesCheckBox.Text = "Удалять пустые строки";
            this.RemoveBlankLinesCheckBox.UseVisualStyleBackColor = true;
            this.RemoveBlankLinesCheckBox.CheckedChanged += new System.EventHandler(this.RemoveBlankLinesCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AlignmentListBox);
            this.groupBox3.Controls.Add(this.AlignmentLabel);
            this.groupBox3.Controls.Add(this.TextWidthTextBox);
            this.groupBox3.Controls.Add(this.TextWidth);
            this.groupBox3.Controls.Add(this.SurroundTable);
            this.groupBox3.Controls.Add(this.AmountOfSpaces);
            this.groupBox3.Controls.Add(this.SpacingAtParagraphStart);
            this.groupBox3.Controls.Add(this.ParagraphsSpacing);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.RemoveBlankLinesCheckBox);
            this.groupBox3.Controls.Add(this.startFootnotesFrom);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(769, 205);
            this.groupBox3.MinimumSize = new System.Drawing.Size(176, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 497);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Коррекции результата";
            // 
            // AlignmentListBox
            // 
            this.AlignmentListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlignmentListBox.DropDownWidth = 88;
            this.AlignmentListBox.Enabled = false;
            this.AlignmentListBox.Items.AddRange(new object[] {
            "Слева",
            "По центру",
            "Справа",
            "Слева и справа"});
            this.AlignmentListBox.Location = new System.Drawing.Point(119, 162);
            this.AlignmentListBox.Name = "AlignmentListBox";
            this.AlignmentListBox.Size = new System.Drawing.Size(108, 21);
            this.AlignmentListBox.TabIndex = 17;
            this.AlignmentListBox.SelectedIndexChanged += new System.EventHandler(this.TextWidthTextBox_Changed);
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.Enabled = false;
            this.AlignmentLabel.Location = new System.Drawing.Point(28, 165);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(85, 13);
            this.AlignmentLabel.TabIndex = 16;
            this.AlignmentLabel.Text = "Выравнивание:";
            // 
            // TextWidthTextBox
            // 
            this.TextWidthTextBox.Enabled = false;
            this.TextWidthTextBox.Location = new System.Drawing.Point(185, 139);
            this.TextWidthTextBox.Mask = "000";
            this.TextWidthTextBox.Name = "TextWidthTextBox";
            this.TextWidthTextBox.ResetOnSpace = false;
            this.TextWidthTextBox.Size = new System.Drawing.Size(42, 20);
            this.TextWidthTextBox.SkipLiterals = false;
            this.TextWidthTextBox.TabIndex = 13;
            this.TextWidthTextBox.Text = "95";
            this.TextWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextWidthTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.TextWidthTextBox.TextChanged += new System.EventHandler(this.TextWidthTextBox_Changed);
            // 
            // TextWidth
            // 
            this.TextWidth.AutoSize = true;
            this.TextWidth.Enabled = false;
            this.TextWidth.Location = new System.Drawing.Point(28, 142);
            this.TextWidth.Name = "TextWidth";
            this.TextWidth.Size = new System.Drawing.Size(100, 13);
            this.TextWidth.TabIndex = 14;
            this.TextWidth.Text = "Ширина текста, %:";
            // 
            // SurroundTable
            // 
            this.SurroundTable.AutoSize = true;
            this.SurroundTable.Location = new System.Drawing.Point(9, 122);
            this.SurroundTable.Name = "SurroundTable";
            this.SurroundTable.Size = new System.Drawing.Size(147, 17);
            this.SurroundTable.TabIndex = 12;
            this.SurroundTable.Text = "Отцентровать с полями";
            this.SurroundTable.UseVisualStyleBackColor = true;
            this.SurroundTable.CheckedChanged += new System.EventHandler(this.SurroundWithTable_CheckedChanged);
            // 
            // AmountOfSpaces
            // 
            this.AmountOfSpaces.Enabled = false;
            this.AmountOfSpaces.Location = new System.Drawing.Point(189, 93);
            this.AmountOfSpaces.Mask = "00";
            this.AmountOfSpaces.Name = "AmountOfSpaces";
            this.AmountOfSpaces.ResetOnSpace = false;
            this.AmountOfSpaces.Size = new System.Drawing.Size(38, 20);
            this.AmountOfSpaces.SkipLiterals = false;
            this.AmountOfSpaces.TabIndex = 10;
            this.AmountOfSpaces.Text = "2";
            this.AmountOfSpaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountOfSpaces.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.AmountOfSpaces.TextChanged += new System.EventHandler(this.AmountOfSpaces_Changed);
            // 
            // SpacingAtParagraphStart
            // 
            this.SpacingAtParagraphStart.AutoSize = true;
            this.SpacingAtParagraphStart.Enabled = false;
            this.SpacingAtParagraphStart.Location = new System.Drawing.Point(28, 96);
            this.SpacingAtParagraphStart.Name = "SpacingAtParagraphStart";
            this.SpacingAtParagraphStart.Size = new System.Drawing.Size(104, 13);
            this.SpacingAtParagraphStart.TabIndex = 11;
            this.SpacingAtParagraphStart.Text = "Отступ в пробелах:";
            // 
            // ParagraphsSpacing
            // 
            this.ParagraphsSpacing.AutoSize = true;
            this.ParagraphsSpacing.Location = new System.Drawing.Point(9, 72);
            this.ParagraphsSpacing.Name = "ParagraphsSpacing";
            this.ParagraphsSpacing.Size = new System.Drawing.Size(176, 17);
            this.ParagraphsSpacing.TabIndex = 10;
            this.ParagraphsSpacing.Text = "Сделать отступ у параграфов";
            this.ParagraphsSpacing.UseVisualStyleBackColor = true;
            this.ParagraphsSpacing.CheckedChanged += new System.EventHandler(this.ParagraphSpacing_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 712);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.Convert_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button Convert_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox startFootnotesFrom;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.CheckBox RemoveBlankLinesCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ParagraphsSpacing;
        private System.Windows.Forms.MaskedTextBox AmountOfSpaces;
        private System.Windows.Forms.Label SpacingAtParagraphStart;
        private System.Windows.Forms.MaskedTextBox TextWidthTextBox;
        private System.Windows.Forms.Label TextWidth;
        private System.Windows.Forms.CheckBox SurroundTable;
        private System.Windows.Forms.Label AlignmentLabel;
        private System.Windows.Forms.ComboBox AlignmentListBox;
    }
}

