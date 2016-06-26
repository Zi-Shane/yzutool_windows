using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace yzutool_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void proxy_openbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("enable_PAC_Proxy.reg");
            }
            catch { }
        }

        private void proxy_closebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("disable_PAC_Proxy.reg");
            }
            catch { }
        }

        private void proxy_checkbtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://210.240.175.62/NTIIS/IP_test.asp");
        }

        private void Wifi_64btn_Click(object sender, EventArgs e)
        {
            Process.Start("802.1x\\YZU_802.1x_64.bat");
            MessageBox.Show("請點選右下方的提示訊息，輸入Portal帳號密碼");
        }

        private void Wifi_86btn_Click(object sender, EventArgs e)
        {
            Process.Start("802.1x\\YZU_802.1x_86.bat");
            MessageBox.Show("請點選右下方的提示訊息，輸入Portal帳號密碼");
        }

        private void windows_KMSbtn_Click(object sender, EventArgs e)
        {
            Process.Start("YZU_Windows_Activation.bat");
        }

        private void Office_KMSbtn_Click(object sender, EventArgs e)
        {
            Process.Start("YZU_Office_Activation.bat");
        }

        private void Downloadbtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://vls.yzu.edu.tw/WebHD/Traditional%20Chinese/Microsoft/");
        }

        private void OutCampusbtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://mskms.yzu.edu.tw/index.asp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            select_cmb.Text = "Proxy設定";
            select_cmb.Items.Add("Proxy設定");
            select_cmb.Items.Add("校園Wifi設定");
            select_cmb.Items.Add("微軟KMS授權");
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
  
            this.ForeColor = Color.Black;
            DialogResult r = MessageBox.Show("建議右鍵\"以系統管理員身分執行\"否則有些功能將無法使用", "通知", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Retry)
                this.Close();
        }


        int msb_click = 0;
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (msb_click == 0)
            {
                MessageBox.Show("可輸入proxy, wifi, kms(lower case)", "說明", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                msb_click = 1;
            }            
        }

        private void Question_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("可輸入proxy, wifi, kms(lower case)", "說明", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void input_txb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (input_txb.Text == "proxy")
                {
                    tabControl1.SelectedIndex = 0;
                }
                else if (input_txb.Text == "wifi")
                {
                    tabControl1.SelectedIndex = 1;
                }
                else if (input_txb.Text == "kms")
                {
                    tabControl1.SelectedIndex = 2;
                }
            }
            catch
            {
                MessageBox.Show("lower case!!!!!!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void select_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_cmb.SelectedIndex == 0)
            {
                tabControl1.SelectedIndex = 0;
            }
            else if (select_cmb.SelectedIndex == 1)
            {
                tabControl1.SelectedIndex = 1;
            }
            else if (select_cmb.SelectedIndex == 2)
            {
                tabControl1.SelectedIndex = 2;
            }
        }

        private void Reference_btn_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();            
        }

        private void Special_function_btn_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            Special_function_btn.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;

  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.ForeColor = colorDialog1.Color;
            select_cmb.ForeColor = colorDialog1.Color;
            input_txb.ForeColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("wifi.bat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Win10通知去除.cmd");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
            this.BackColor = Color.Gray;
            Special_function_btn.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
        }
    }
}
