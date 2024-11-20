using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notePad
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
            System.IO.File.WriteAllText(s.FileName, txtmaintext.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmaintext.Text = "";
        }

        private void تنظیماترنگپسرمینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            txtmaintext.BackColor = c.Color;
        }

        private void تنظیماترنگمتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog t = new ColorDialog();
            t.ShowDialog();
            txtmaintext.ForeColor = t.Color;
        }

        private void تنظیماتفونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            txtmaintext.Font = f.Font;
        }

        private void بازکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            txtmaintext.Text = System.IO.File.ReadAllText(o.FileName);
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }
    }
}
