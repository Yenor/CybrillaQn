namespace URLShortnerCSharp
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
            this.URLBox = new System.Windows.Forms.TextBox();
            this.GetShortButton = new System.Windows.Forms.Button();
            this.URLShortList = new System.Windows.Forms.ListBox();
            this.GoToURL = new System.Windows.Forms.Button();
            this.OutputUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URLBox
            // 
            this.URLBox.Location = new System.Drawing.Point(35, 29);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(537, 20);
            this.URLBox.TabIndex = 0;
            // 
            // GetShortButton
            // 
            this.GetShortButton.Location = new System.Drawing.Point(631, 25);
            this.GetShortButton.Name = "GetShortButton";
            this.GetShortButton.Size = new System.Drawing.Size(75, 23);
            this.GetShortButton.TabIndex = 1;
            this.GetShortButton.Text = "GetItShort";
            this.GetShortButton.UseVisualStyleBackColor = true;
            this.GetShortButton.Click += new System.EventHandler(this.GetShortButton_Click);
            // 
            // URLShortList
            // 
            this.URLShortList.FormattingEnabled = true;
            this.URLShortList.Location = new System.Drawing.Point(24, 83);
            this.URLShortList.Name = "URLShortList";
            this.URLShortList.Size = new System.Drawing.Size(134, 186);
            this.URLShortList.TabIndex = 2;
            // 
            // GoToURL
            // 
            this.GoToURL.Location = new System.Drawing.Point(179, 166);
            this.GoToURL.Name = "GoToURL";
            this.GoToURL.Size = new System.Drawing.Size(75, 23);
            this.GoToURL.TabIndex = 3;
            this.GoToURL.Text = "GO";
            this.GoToURL.UseVisualStyleBackColor = true;
            this.GoToURL.Click += new System.EventHandler(this.GoToURL_Click);
            // 
            // OutputUrl
            // 
            this.OutputUrl.AutoSize = true;
            this.OutputUrl.Location = new System.Drawing.Point(322, 175);
            this.OutputUrl.Name = "OutputUrl";
            this.OutputUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputUrl.Size = new System.Drawing.Size(0, 13);
            this.OutputUrl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 393);
            this.Controls.Add(this.OutputUrl);
            this.Controls.Add(this.GoToURL);
            this.Controls.Add(this.URLShortList);
            this.Controls.Add(this.GetShortButton);
            this.Controls.Add(this.URLBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button GetShortButton;
        private System.Windows.Forms.ListBox URLShortList;
        private System.Windows.Forms.Button GoToURL;
        private System.Windows.Forms.Label OutputUrl;
    }
}

