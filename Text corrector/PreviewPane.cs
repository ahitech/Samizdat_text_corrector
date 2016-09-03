using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_corrector
{
    public partial class PreviewPane : Form
    {
        public PreviewPane(MainWindow reference)
        {
            InitializeComponent();

            String toDisplay = "<html><head><title>Предварительный просмотр</title></head><body bgcolor=#E9E9E9>"
                + reference.OutputBox.Text + "</body></html>";

            this.WebBrowserPanel.DocumentText = toDisplay;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
