using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace webBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebBrowser web = new WebBrowser();
        int r = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            tabControl1.TabPages.Add("New Tab");
            tabControl1.SelectTab(r);
            tabControl1.SelectedTab.Controls.Add(web);
            r += 1;

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("google.az");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            tabControl1.TabPages.Add("New Tab");
            tabControl1.SelectTab(r);
            tabControl1.SelectedTab.Controls.Add(web);
            r += 1;
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("google.az");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(tabControl1.TabPages.Count-1>0){
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                r -= 1;
            }
        }
    }
}
