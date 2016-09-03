using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Text_corrector
{
    public partial class InputBox : System.Windows.Forms.RichTextBox
    {
        public InputBox()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            bool ctrlV = e.Modifiers == Keys.Control && e.KeyCode == Keys.V;
            bool shiftIns = e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert;

            if (ctrlV || shiftIns)
                InputBox_Paste();
        }

        public void InputBox_Paste()
        {
            this.Text = "";

            // Get a web browser
            WebBrowser web = new WebBrowser();

            // Load the MSHTML component into the web browser control
            web.Navigate("about:blank");
            Application.DoEvents();

            // Change into design mode
            ((mshtml.HTMLDocument)web.Document.DomDocument).designMode = "On";
            Application.DoEvents();

            // Paste the clipboard contents into the control
            object o = System.Reflection.Missing.Value;
            ((SHDocVw.WebBrowser)web.ActiveXInstance).ExecWB(
               SHDocVw.OLECMDID.OLECMDID_PASTE,
               SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref o, ref o);
            Application.DoEvents();

            // Extract the resulting HTML
            this.Text = "";
            this.Text = web.Document.Body.InnerHtml;

        }

        protected override void WndProc(ref Message m)
        {
            // Trap WM_PASTE:
            if (m.Msg == 0x302 && Clipboard.ContainsText())
            {
                InputBox_Paste();
                return;
            }
            base.WndProc(ref m);
        }

    }
}
