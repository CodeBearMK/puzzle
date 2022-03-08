using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn11.ImageIndex = 4;
            btn12.ImageIndex = 8;
            btn13.ImageIndex = 6;
            btn21.ImageIndex = 2;
            btn22.ImageIndex = 0;
            btn23.ImageIndex = 5;
            btn31.ImageIndex = 7;
            btn32.ImageIndex = 3;
            btn33.ImageIndex = 1;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn12.ImageIndex == 8)
            {
                btn12.ImageIndex = btn11.ImageIndex;
                btn11.ImageIndex = 8;
            }
            else if (btn21.ImageIndex == 8)
            {
                btn21.ImageIndex = btn11.ImageIndex;
                btn11.ImageIndex = 8;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn11.ImageIndex == 8)
            {
                btn11.ImageIndex = btn12.ImageIndex;
                btn12.ImageIndex = 8;
            }
            else if (btn13.ImageIndex == 8)
            {
                btn13.ImageIndex = btn12.ImageIndex;
                btn12.ImageIndex = 8;
            }
            else if (btn22.ImageIndex == 8)
            {
                btn22.ImageIndex = btn12.ImageIndex;
                btn12.ImageIndex = 8;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (btn12.ImageIndex == 8)
            {
                btn12.ImageIndex = btn13.ImageIndex;
                btn13.ImageIndex = 8;
            }
            else if (btn23.ImageIndex == 8)
            {
                btn23.ImageIndex = btn13.ImageIndex;
                btn13.ImageIndex = 8;
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (btn11.ImageIndex == 8)
            {
                btn11.ImageIndex = btn21.ImageIndex;
                btn21.ImageIndex = 8;
            }
            else if (btn22.ImageIndex == 8)
            {
                btn22.ImageIndex = btn21.ImageIndex;
                btn21.ImageIndex = 8;
            }
            else if (btn31.ImageIndex == 8)
            {
                btn31.ImageIndex = btn21.ImageIndex;
                btn21.ImageIndex = 8;
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (btn12.ImageIndex == 8)
            {
                btn12.ImageIndex = btn22.ImageIndex;
                btn22.ImageIndex = 8;
            }
            else if (btn21.ImageIndex == 8)
            {
                btn21.ImageIndex = btn22.ImageIndex;
                btn22.ImageIndex = 8;
            }
            else if (btn32.ImageIndex == 8)
            {
                btn32.ImageIndex = btn22.ImageIndex;
                btn22.ImageIndex = 8;
            }
            else if (btn23.ImageIndex == 8)
            {
                btn23.ImageIndex = btn22.ImageIndex;
                btn22.ImageIndex = 8;
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (btn13.ImageIndex == 8)
            {
                btn13.ImageIndex = btn23.ImageIndex;
                btn23.ImageIndex = 8;
            }
            else if (btn22.ImageIndex == 8)
            {
                btn22.ImageIndex = btn23.ImageIndex;
                btn23.ImageIndex = 8;
            }
            else if (btn33.ImageIndex == 8)
            {
                btn33.ImageIndex = btn23.ImageIndex;
                btn23.ImageIndex = 8;
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (btn21.ImageIndex == 8)
            {
                btn21.ImageIndex = btn31.ImageIndex;
                btn31.ImageIndex = 8;
            }
            else if (btn32.ImageIndex == 8)
            {
                btn32.ImageIndex = btn31.ImageIndex;
                btn31.ImageIndex = 8;
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (btn31.ImageIndex == 8)
            {
                btn31.ImageIndex = btn32.ImageIndex;
                btn32.ImageIndex = 8;
            }
            else if (btn22.ImageIndex == 8)
            {
                btn22.ImageIndex = btn32.ImageIndex;
                btn32.ImageIndex = 8;
            }
            else if (btn33.ImageIndex == 8)
            {
                btn33.ImageIndex = btn32.ImageIndex;
                btn32.ImageIndex = 8;
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (btn32.ImageIndex == 8)
            {
                btn32.ImageIndex = btn33.ImageIndex;
                btn33.ImageIndex = 8;
            }
            else if (btn23.ImageIndex == 8)
            {
                btn23.ImageIndex = btn33.ImageIndex;
                btn33.ImageIndex = 8;
            }
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            if (btn11.ImageIndex == 0 && btn12.ImageIndex == 1 && btn13.ImageIndex == 2 &&
                btn21.ImageIndex == 3 && btn22.ImageIndex == 4 && btn23.ImageIndex == 5 &&
                btn31.ImageIndex == 6 && btn32.ImageIndex == 7 && btn33.ImageIndex == 8)
            {
                MessageBox.Show("恭喜完成拼圖!", "訊息", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("還沒有拼正確，繼續加油", "訊息", MessageBoxButtons.OK);
            }
        }
    }
}
