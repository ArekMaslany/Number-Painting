using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Painting_application
{
    public partial class Not_MS_Paint : Form
    {

        Pen myPen = new Pen(Color.Black);
        Graphics g = null;


        static Int64 centre_x, centre_y;
        static Int64 start_x, start_y;
        static Int64 end_x, end_y;

        static Int64 my_angle = 0;
        static Int64 my_length = 0;
        static double my_incerement = 0;
        static Int64 num_lines = 0;

        public Not_MS_Paint()
        {
            InitializeComponent();
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 2;
            g = canvas.CreateGraphics();
            for(int i = 0; i < Int32.Parse(txtNumberLines.Text); i++)
                drawLine();
        }

        private void drawLine()
        {
            Random randomGen = new Random();
            myPen.Color = Color.FromArgb(randomGen.Next(255), randomGen.Next(25), randomGen.Next(180));
            my_angle = my_angle + Int32.Parse(txtAngle.Text);
            my_length = Convert.ToInt64(my_length + double.Parse(txtIncrement.Text));

            end_x = (Int64)(start_x + Math.Cos(my_angle * .0174532925195) * my_length);
            end_y = (Int64)(start_y + Math.Sin(my_angle * .0174532925195) * my_length);

            Point[] points =
                {
                    new Point(Convert.ToInt32(start_x), Convert.ToInt32(start_y)),
                    new Point(Convert.ToInt32(end_x), Convert.ToInt32(end_y))
                };

            start_x = end_x;
            start_y = end_y;

            g.DrawLines(myPen, points);
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            my_length = Int64.Parse(txtLength.Text);
            my_incerement = Double.Parse(txtIncrement.Text);
            my_angle = Int64.Parse(txtAngle.Text);
            lblActual.Text = Convert.ToString(my_angle % 360);
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;

            canvas.Refresh();
        }
    }
}
