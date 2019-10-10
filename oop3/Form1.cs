using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop3
{
    public partial class Form1 : Form
    {
        bool paint = false;
        SolidBrush color = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearClick(object sender, EventArgs e)
        {
            Graphics g1 = panel1.CreateGraphics();
            g1.Clear(panel1.BackColor);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                Graphics g = panel1.CreateGraphics();
                g.FillEllipse(color, e.X, e.Y, 10, 10);
                g.Dispose();
            }
        }

        private void btnChangeColor(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Чёрный":
                    color = new SolidBrush(Color.Black);
                    break;
                case "Красный":
                    color = new SolidBrush(Color.Red);
                    break;
                case "Зелёный":
                    color = new SolidBrush(Color.Green);
                    break;
                case "Жёлтый":
                    color = new SolidBrush(Color.Yellow);
                    break;
            }
        }
    }
}
