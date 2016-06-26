namespace yzutool_windows
{
    partial class Form2
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
            this.kaiyeeGit_lbl = new System.Windows.Forms.Label();
            this.YZUOLIS_lbl = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // kaiyeeGit_lbl
            // 
            this.kaiyeeGit_lbl.AutoSize = true;
            this.kaiyeeGit_lbl.Location = new System.Drawing.Point(37, 47);
            this.kaiyeeGit_lbl.Name = "kaiyeeGit_lbl";
            this.kaiyeeGit_lbl.Size = new System.Drawing.Size(89, 15);
            this.kaiyeeGit_lbl.TabIndex = 1;
            this.kaiyeeGit_lbl.Text = "kaiyee yzutool";
            // 
            // YZUOLIS_lbl
            // 
            this.YZUOLIS_lbl.AutoSize = true;
            this.YZUOLIS_lbl.Location = new System.Drawing.Point(37, 128);
            this.YZUOLIS_lbl.Name = "YZUOLIS_lbl";
            this.YZUOLIS_lbl.Size = new System.Drawing.Size(82, 15);
            this.YZUOLIS_lbl.TabIndex = 2;
            this.YZUOLIS_lbl.Text = "元智資服處";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(37, 160);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(193, 15);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://www.yzu.edu.tw/admin/is/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(37, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(230, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Oschangkai/yzuTool";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 232);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.YZUOLIS_lbl);
            this.Controls.Add(this.kaiyeeGit_lbl);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form2";
            this.Text = "resource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label kaiyeeGit_lbl;
        private System.Windows.Forms.Label YZUOLIS_lbl;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}