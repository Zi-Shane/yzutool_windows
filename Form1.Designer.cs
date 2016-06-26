namespace yzutool_windows
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.select_cmb = new System.Windows.Forms.ComboBox();
            this.input_txb = new System.Windows.Forms.TextBox();
            this.Input_lbl = new System.Windows.Forms.Label();
            this.select_lbl = new System.Windows.Forms.Label();
            this.Question_btn = new System.Windows.Forms.Button();
            this.Reference_btn = new System.Windows.Forms.Button();
            this.Special_function_btn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.KMSlbl = new System.Windows.Forms.Label();
            this.windows_KMSbtn = new System.Windows.Forms.Button();
            this.OutCampusbtn = new System.Windows.Forms.Button();
            this.Office_KMSbtn = new System.Windows.Forms.Button();
            this.Downloadbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Wifi_lbl = new System.Windows.Forms.Label();
            this.Wifi_64 = new System.Windows.Forms.Button();
            this.Wifi_86 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.proxy_lbl = new System.Windows.Forms.Label();
            this.proxy_openbtn = new System.Windows.Forms.Button();
            this.proxy_closebtn = new System.Windows.Forms.Button();
            this.proxy_checkbtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_cmb
            // 
            this.select_cmb.FormattingEnabled = true;
            this.select_cmb.Location = new System.Drawing.Point(400, 60);
            this.select_cmb.Name = "select_cmb";
            this.select_cmb.Size = new System.Drawing.Size(192, 23);
            this.select_cmb.TabIndex = 12;
            this.select_cmb.SelectedIndexChanged += new System.EventHandler(this.select_cmb_SelectedIndexChanged);
            // 
            // input_txb
            // 
            this.input_txb.Location = new System.Drawing.Point(113, 58);
            this.input_txb.Name = "input_txb";
            this.input_txb.Size = new System.Drawing.Size(100, 25);
            this.input_txb.TabIndex = 14;
            this.input_txb.Click += new System.EventHandler(this.textBox1_Click);
            this.input_txb.TextChanged += new System.EventHandler(this.input_txb_TextChanged);
            // 
            // Input_lbl
            // 
            this.Input_lbl.AutoSize = true;
            this.Input_lbl.Location = new System.Drawing.Point(31, 63);
            this.Input_lbl.Name = "Input_lbl";
            this.Input_lbl.Size = new System.Drawing.Size(67, 15);
            this.Input_lbl.TabIndex = 15;
            this.Input_lbl.Text = "輸入功能";
            // 
            // select_lbl
            // 
            this.select_lbl.AutoSize = true;
            this.select_lbl.Location = new System.Drawing.Point(318, 64);
            this.select_lbl.Name = "select_lbl";
            this.select_lbl.Size = new System.Drawing.Size(67, 15);
            this.select_lbl.TabIndex = 16;
            this.select_lbl.Text = "選擇功能";
            // 
            // Question_btn
            // 
            this.Question_btn.Location = new System.Drawing.Point(219, 58);
            this.Question_btn.Name = "Question_btn";
            this.Question_btn.Size = new System.Drawing.Size(26, 27);
            this.Question_btn.TabIndex = 17;
            this.Question_btn.Text = "？";
            this.Question_btn.UseVisualStyleBackColor = true;
            this.Question_btn.Click += new System.EventHandler(this.Question_btn_Click);
            // 
            // Reference_btn
            // 
            this.Reference_btn.Location = new System.Drawing.Point(569, 325);
            this.Reference_btn.Name = "Reference_btn";
            this.Reference_btn.Size = new System.Drawing.Size(75, 28);
            this.Reference_btn.TabIndex = 18;
            this.Reference_btn.Text = "參考來源";
            this.Reference_btn.UseVisualStyleBackColor = true;
            this.Reference_btn.Click += new System.EventHandler(this.Reference_btn_Click);
            // 
            // Special_function_btn
            // 
            this.Special_function_btn.Location = new System.Drawing.Point(434, 325);
            this.Special_function_btn.Name = "Special_function_btn";
            this.Special_function_btn.Size = new System.Drawing.Size(118, 28);
            this.Special_function_btn.TabIndex = 19;
            this.Special_function_btn.Text = "開啟特殊功能";
            this.Special_function_btn.UseVisualStyleBackColor = true;
            this.Special_function_btn.Click += new System.EventHandler(this.Special_function_btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.KMSlbl);
            this.tabPage3.Controls.Add(this.windows_KMSbtn);
            this.tabPage3.Controls.Add(this.OutCampusbtn);
            this.tabPage3.Controls.Add(this.Office_KMSbtn);
            this.tabPage3.Controls.Add(this.Downloadbtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(606, 146);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "微軟KMS授權";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // KMSlbl
            // 
            this.KMSlbl.AutoSize = true;
            this.KMSlbl.Location = new System.Drawing.Point(40, 41);
            this.KMSlbl.Name = "KMSlbl";
            this.KMSlbl.Size = new System.Drawing.Size(97, 15);
            this.KMSlbl.TabIndex = 7;
            this.KMSlbl.Text = "微軟授權啟用";
            // 
            // windows_KMSbtn
            // 
            this.windows_KMSbtn.Location = new System.Drawing.Point(169, 34);
            this.windows_KMSbtn.Name = "windows_KMSbtn";
            this.windows_KMSbtn.Size = new System.Drawing.Size(104, 29);
            this.windows_KMSbtn.TabIndex = 8;
            this.windows_KMSbtn.Text = "Windows 7-10";
            this.windows_KMSbtn.UseVisualStyleBackColor = true;
            this.windows_KMSbtn.Click += new System.EventHandler(this.windows_KMSbtn_Click);
            // 
            // OutCampusbtn
            // 
            this.OutCampusbtn.Location = new System.Drawing.Point(470, 34);
            this.OutCampusbtn.Name = "OutCampusbtn";
            this.OutCampusbtn.Size = new System.Drawing.Size(95, 31);
            this.OutCampusbtn.TabIndex = 11;
            this.OutCampusbtn.Text = "校外啟用";
            this.OutCampusbtn.UseVisualStyleBackColor = true;
            this.OutCampusbtn.Click += new System.EventHandler(this.OutCampusbtn_Click);
            // 
            // Office_KMSbtn
            // 
            this.Office_KMSbtn.Location = new System.Drawing.Point(298, 34);
            this.Office_KMSbtn.Name = "Office_KMSbtn";
            this.Office_KMSbtn.Size = new System.Drawing.Size(113, 29);
            this.Office_KMSbtn.TabIndex = 9;
            this.Office_KMSbtn.Text = "Office2013-2016";
            this.Office_KMSbtn.UseVisualStyleBackColor = true;
            this.Office_KMSbtn.Click += new System.EventHandler(this.Office_KMSbtn_Click);
            // 
            // Downloadbtn
            // 
            this.Downloadbtn.Location = new System.Drawing.Point(470, 83);
            this.Downloadbtn.Name = "Downloadbtn";
            this.Downloadbtn.Size = new System.Drawing.Size(95, 29);
            this.Downloadbtn.TabIndex = 10;
            this.Downloadbtn.Text = "下載";
            this.Downloadbtn.UseVisualStyleBackColor = true;
            this.Downloadbtn.Click += new System.EventHandler(this.Downloadbtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Wifi_lbl);
            this.tabPage2.Controls.Add(this.Wifi_64);
            this.tabPage2.Controls.Add(this.Wifi_86);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "校園wifi設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Wifi_lbl
            // 
            this.Wifi_lbl.AutoSize = true;
            this.Wifi_lbl.Location = new System.Drawing.Point(44, 42);
            this.Wifi_lbl.Name = "Wifi_lbl";
            this.Wifi_lbl.Size = new System.Drawing.Size(93, 15);
            this.Wifi_lbl.TabIndex = 4;
            this.Wifi_lbl.Text = "校園Wifi設定";
            // 
            // Wifi_64
            // 
            this.Wifi_64.Location = new System.Drawing.Point(173, 35);
            this.Wifi_64.Name = "Wifi_64";
            this.Wifi_64.Size = new System.Drawing.Size(104, 29);
            this.Wifi_64.TabIndex = 5;
            this.Wifi_64.Text = "x64 系統";
            this.Wifi_64.UseVisualStyleBackColor = true;
            this.Wifi_64.Click += new System.EventHandler(this.Wifi_64btn_Click);
            // 
            // Wifi_86
            // 
            this.Wifi_86.Location = new System.Drawing.Point(302, 35);
            this.Wifi_86.Name = "Wifi_86";
            this.Wifi_86.Size = new System.Drawing.Size(113, 29);
            this.Wifi_86.TabIndex = 6;
            this.Wifi_86.Text = "x86 系統";
            this.Wifi_86.UseVisualStyleBackColor = true;
            this.Wifi_86.Click += new System.EventHandler(this.Wifi_86btn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.proxy_lbl);
            this.tabPage1.Controls.Add(this.proxy_openbtn);
            this.tabPage1.Controls.Add(this.proxy_closebtn);
            this.tabPage1.Controls.Add(this.proxy_checkbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proxy設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // proxy_lbl
            // 
            this.proxy_lbl.AutoSize = true;
            this.proxy_lbl.Location = new System.Drawing.Point(38, 43);
            this.proxy_lbl.Name = "proxy_lbl";
            this.proxy_lbl.Size = new System.Drawing.Size(71, 15);
            this.proxy_lbl.TabIndex = 2;
            this.proxy_lbl.Text = "Proxy設定";
            // 
            // proxy_openbtn
            // 
            this.proxy_openbtn.Location = new System.Drawing.Point(158, 36);
            this.proxy_openbtn.Name = "proxy_openbtn";
            this.proxy_openbtn.Size = new System.Drawing.Size(104, 29);
            this.proxy_openbtn.TabIndex = 0;
            this.proxy_openbtn.Text = "開啟";
            this.proxy_openbtn.UseVisualStyleBackColor = true;
            this.proxy_openbtn.Click += new System.EventHandler(this.proxy_openbtn_Click);
            // 
            // proxy_closebtn
            // 
            this.proxy_closebtn.Location = new System.Drawing.Point(287, 36);
            this.proxy_closebtn.Name = "proxy_closebtn";
            this.proxy_closebtn.Size = new System.Drawing.Size(113, 29);
            this.proxy_closebtn.TabIndex = 1;
            this.proxy_closebtn.Text = "關閉";
            this.proxy_closebtn.UseVisualStyleBackColor = true;
            this.proxy_closebtn.Click += new System.EventHandler(this.proxy_closebtn_Click);
            // 
            // proxy_checkbtn
            // 
            this.proxy_checkbtn.Location = new System.Drawing.Point(454, 36);
            this.proxy_checkbtn.Name = "proxy_checkbtn";
            this.proxy_checkbtn.Size = new System.Drawing.Size(95, 29);
            this.proxy_checkbtn.TabIndex = 3;
            this.proxy_checkbtn.Text = "檢查";
            this.proxy_checkbtn.UseVisualStyleBackColor = true;
            this.proxy_checkbtn.Click += new System.EventHandler(this.proxy_checkbtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(30, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 175);
            this.tabControl1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "視窗底色";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "字體顏色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "筆電wifi基地台";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(314, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "windows10更新通知關閉";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(676, 390);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Special_function_btn);
            this.Controls.Add(this.Reference_btn);
            this.Controls.Add(this.Question_btn);
            this.Controls.Add(this.select_lbl);
            this.Controls.Add(this.Input_lbl);
            this.Controls.Add(this.input_txb);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.select_cmb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YZUTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox select_cmb;
        private System.Windows.Forms.TextBox input_txb;
        private System.Windows.Forms.Label Input_lbl;
        private System.Windows.Forms.Label select_lbl;
        private System.Windows.Forms.Button Question_btn;
        private System.Windows.Forms.Button Reference_btn;
        private System.Windows.Forms.Button Special_function_btn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label KMSlbl;
        private System.Windows.Forms.Button windows_KMSbtn;
        private System.Windows.Forms.Button OutCampusbtn;
        private System.Windows.Forms.Button Office_KMSbtn;
        private System.Windows.Forms.Button Downloadbtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Wifi_lbl;
        private System.Windows.Forms.Button Wifi_64;
        private System.Windows.Forms.Button Wifi_86;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label proxy_lbl;
        private System.Windows.Forms.Button proxy_openbtn;
        private System.Windows.Forms.Button proxy_closebtn;
        private System.Windows.Forms.Button proxy_checkbtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

