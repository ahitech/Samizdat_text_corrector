namespace Text_corrector
{
    partial class PreviewPane
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.WebBrowserPanel = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WebBrowserPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 30);
            this.groupBox1.Size = new System.Drawing.Size(564, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вот как будет выглядеть гениальный креатифф:";
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DoneButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DoneButton.Location = new System.Drawing.Point(10, 428);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(564, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Круть безумная!";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // WebBrowserPanel
            // 
            this.WebBrowserPanel.AllowNavigation = false;
            this.WebBrowserPanel.AllowWebBrowserDrop = false;
            this.WebBrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserPanel.Location = new System.Drawing.Point(10, 23);
            this.WebBrowserPanel.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserPanel.Name = "WebBrowserPanel";
            this.WebBrowserPanel.Size = new System.Drawing.Size(544, 388);
            this.WebBrowserPanel.TabIndex = 0;
            this.WebBrowserPanel.WebBrowserShortcutsEnabled = false;
            // 
            // PreviewPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.DoneButton;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PreviewPane";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Это превью";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.WebBrowser WebBrowserPanel;
    }
}