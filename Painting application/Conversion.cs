using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painting_application
{
    public partial class Conversion : Form
    {
        //Bitmap img = new Bitmap(width, height);
        Pen myPen = new Pen(Color.Black);
        Graphics g = null;

        static Int16 width, height;
        static Int64 centre_x, centre_y;
        static Int64 start_x, start_y;
        static Int64 end_x, end_y;
        static Int64 angle = 0;
        static Int64 length = 0;
        static double increment = 0;

        public Conversion()
        {
            InitializeComponent();
            width = Convert.ToInt16(this.Width);
            height = Convert.ToInt16(this.Height);
            start_x = centre_x = panCanvas.Width / 2;
            start_y = centre_y = panCanvas.Height / 2;
        }

        private void panCanvas_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 2;
            g = panCanvas.CreateGraphics();
            for (int i = 1; i <= Convert.ToInt64(numLines.Value); i++)
                drawLine();
        }

        private void drawLine()
        {
            Random randomGen = new Random();
            //Color.FromArgb(randomGen.Next(255), randomGen.Next(25), randomGen.Next(180));
            //picbLineColour.BackColor;
            myPen.Color = Color.FromArgb(randomGen.Next(255), randomGen.Next(255), randomGen.Next(255));
            angle = angle + Convert.ToInt64(numAngle.Value);
            length = Convert.ToInt64(length + Convert.ToDouble(numIncrement.Value));
            //1degree in radians = old - 0.0174532925195 new - 0.017453292519944, not perf. square if pen size is 1px
            end_x = (Int64)(start_x + Math.Cos(angle * .0174532925199344) * length);
            end_y = (Int64)(start_y + Math.Sin(angle * .0174532925199344) * length);

            Point[] points =
                {
                    new Point(Convert.ToInt32(start_x), Convert.ToInt32(start_y)),
                    new Point(Convert.ToInt32(end_x), Convert.ToInt32(end_y))
                };

            start_x = end_x;
            start_y = end_y;

            g.DrawLines(myPen, points);
        }

        private void Conversion_Load(object sender, EventArgs e)
        {
            // no smaller than property size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            // no larger than screen size
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        } 

        private void btnPaint_Click(object sender, EventArgs e)
        {   
            length = Convert.ToInt64(numLength.Value);
            increment = Convert.ToDouble(numIncrement.Value);
            angle = Convert.ToInt64(numAngle.Value);
            toolTip.SetToolTip(lblAngle, "The remainding angle is: " + Convert.ToString(angle % 360));
            toolTip.SetToolTip(numAngle, "Current angle is: : " + Convert.ToString(angle));
            start_x = panCanvas.Width / 2;
            start_y = panCanvas.Height / 2;
            panCanvas.Refresh();
        }

        private void picbLineColour_Click(object sender, EventArgs e)
        {
            if (colourLines.ShowDialog() == DialogResult.OK)
            {
                picbLineColour.BackColor = colourLines.Color;

            }
        }

    }
}
