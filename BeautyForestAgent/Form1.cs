using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }
        private void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.beautyTray.Visible = !visible;
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }


        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;//종료 취소 창이 안닫힘
            VisibleChange(false);//창을 숩겨주는것
        }

        private void BeautyTray_DoubleClick(object sender, EventArgs e)
        {
            VisibleChange(true);//창을 숩겨주는것
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.beautyTray.Visible = false;
            Application.ExitThread();
        }
    }
}
