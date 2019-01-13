using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class timeForm : Form
    {
        static DateTime dt = new DateTime();
        bool LontonBtn;
        public timeForm()
        {
            InitializeComponent();
            timeLbl.TextAlign = ContentAlignment.MiddleCenter;
            timeLbl.Font = new Font(FontFamily.GenericSerif, 50);
            timeLbl.ForeColor = Color.BurlyWood;
            timer1.Start();
        }

        private void bakuBtn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Font = new Font(FontFamily.GenericSerif, 15);
        }

        private void bakuBtn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Font = new Font(FontFamily.GenericSerif, 8);
        }

        private void londonBtn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Font = new Font(FontFamily.GenericSerif, 15);
        }

        private void londonBtn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Font = new Font(FontFamily.GenericSerif, 8);
        }

        private void bakuBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"baku.jpg");
            LontonBtn = false;
        }

        private void londonBtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"london.jpg");
            LontonBtn = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            if (!LontonBtn) timeLbl.Text = $"{dt.ToLongTimeString()}"; 
            else timeLbl.Text = $"{dt.AddHours(-4).ToLongTimeString()}";
        }
    }
}
