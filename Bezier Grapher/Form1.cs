using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezier_Grapher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            pb_main.Image = new Bitmap(pb_main.Width, pb_main.Height);

            using (Graphics g = Graphics.FromImage(pb_main.Image))
                g.Clear(Color.White);

            foreach (NumericUpDown num in this.Controls.OfType<NumericUpDown>())
                num.Enter += Highlight;
        }

        private List<PointF> points = new List<PointF>();
        float scaleX;
        float scaleY;
        PointF P0;
        PointF P1;
        PointF P2;
        PointF P3;
        PointF dP;
        float k;

        private void btn_graph_Click(object sender, EventArgs e)
        {
            P0 = new PointF((float)num_P0X.Value, (float)num_P0Y.Value); //new PointF(0, 0);   
            P1 = new PointF((float)num_P1X.Value, (float)num_P1Y.Value); //new PointF(9, 30);  
            P2 = new PointF((float)num_P2X.Value, (float)num_P2Y.Value); //new PointF(50, 20); 
            P3 = new PointF((float)num_P3X.Value, (float)num_P3Y.Value); //new PointF(75, 45); 
            dP = new PointF((float)num_dX.Value , (float)num_dY.Value );
            scaleX = (float)num_scaleX.Value;
            scaleY = (float)num_scaleY.Value;
            k = (float)num_k.Value;

            pb_main.Image = new Bitmap(pb_main.Width, pb_main.Height);

            Image bmp = pb_main.Image;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                PointF lastPoint = PointF.Empty;
                PointF tempPoint = PointF.Empty;

                foreach (PointF p in points)
                {
                    tempPoint = p;

                    tempPoint.X *= k;
                    tempPoint.Y *= k;

                    tempPoint.Y = (float)pb_main.Height - tempPoint.Y;

                    if (lastPoint != PointF.Empty && Distance(lastPoint, tempPoint) < 1)
                        g.DrawLine(new Pen(Color.Black, k), lastPoint, tempPoint);

                    lastPoint = tempPoint;
                }

                for (float i = 0; i < (tbar_range.Value / 100f); i += (float)num_dL.Value)
                {
                    PointF P0i = BezierFunc(P0, P1, P2, P3, i, dP);
                    PointF P1i = BezierFunc(P0, P1, P2, P3, i + (float)num_dL.Value, dP);

                    P0i.X *= (float)num_scaleX.Value;
                    P0i.Y *= (float)num_scaleY.Value;
                    P1i.X *= (float)num_scaleX.Value;
                    P1i.Y *= (float)num_scaleY.Value;

                    if ((points.Count > 0 && P0i != points[points.Count - 1]) || points.Count == 0)
                        points.Add(P0i);

                    P0i.X *= k;
                    P0i.Y *= k;
                    P1i.X *= k;
                    P1i.Y *= k;

                    P0i.Y = pb_main.Height - P0i.Y;
                    P1i.Y = pb_main.Height - P1i.Y;

                    if (Distance(P0i, P1i) < 1)
                        g.DrawLine(new Pen(Color.Black, k), P0i, P1i);
                }

                points.Add(BezierFunc(P0, P1, P2, P3, tbar_range.Value / 100f, dP));
            }

            pb_main.Invalidate();

            MessageBox.Show("Done!");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pb_main.Image = new Bitmap(pb_main.Width, pb_main.Height);
            points = new List<PointF>();

            using (Graphics g = Graphics.FromImage(pb_main.Image))
                g.Clear(Color.White);
        }

        private void tbar_range_Scroll(object sender, EventArgs e)
        {
            lb_range.Text = (tbar_range.Value / 100f).ToString();
        }

        private void btn_dup_Click(object sender, EventArgs e)
        {
            if (points.Count > 0)
            {
                List<PointF> newPoints = new List<PointF>();

                for (int i = points.Count - 2; i >= 0; i--)
                    newPoints.Add(new PointF(points[points.Count - 1].X + (points[points.Count - 1].X - points[i].X), points[i].Y));

                Image bmp = pb_main.Image;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    PointF P0i = newPoints[0];
                    PointF P1i = points[points.Count - 1];

                    P0i.X *= (float)num_scaleX.Value;
                    P0i.Y *= (float)num_scaleY.Value;
                    P1i.X *= (float)num_scaleX.Value;
                    P1i.Y *= (float)num_scaleY.Value;

                    P0i.X *= k;
                    P0i.Y *= k;
                    P1i.X *= k;
                    P1i.Y *= k;

                    P0i.Y = pb_main.Height - P0i.Y;
                    P1i.Y = pb_main.Height - P1i.Y;

                    if (Distance(P0i, P1i) < 1)
                        g.DrawLine(new Pen(Color.Black, k), P0i, P1i);
                }

                points.AddRange(newPoints);

                bmp = pb_main.Image;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    for (int i = 0; i < newPoints.Count - 1; i++)
                    {
                        PointF P0i = newPoints[i];
                        PointF P1i = newPoints[i + 1];

                        P0i.X *= k;
                        P0i.Y *= k;
                        P1i.X *= k;
                        P1i.Y *= k;

                        P0i.Y = pb_main.Height - P0i.Y;
                        P1i.Y = pb_main.Height - P1i.Y;

                        g.DrawLine(new Pen(Color.Black, k), P0i, P1i);
                    }
                }

                pb_main.Invalidate();

                MessageBox.Show("Done!");
            }
            else
                MessageBox.Show("Nothing to duplicate!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        #region Methods

        private PointF BezierFunc(PointF P0, PointF P1, PointF P2, PointF P3, float t, PointF dP)
        {
            float x = (float)
                (Math.Pow(1 - t, 3) * P0.X +
                3 * Math.Pow(1 - t, 2) * t * P1.X +
                3 * (1 - t) * Math.Pow(t, 2) * P2.X +
                Math.Pow(t, 3) * P3.X);

            float y = (float)
                (Math.Pow(1 - t, 3) * P0.Y +
                3 * Math.Pow(1 - t, 2) * t * P1.Y +
                3 * (1 - t) * Math.Pow(t, 2) * P2.Y +
                Math.Pow(t, 3) * P3.Y);

            return new PointF(dP.X + x, dP.Y + y);
        }

        private float Distance(PointF P0, PointF P1)
        {
            return (float)Math.Sqrt(((P0.X - P1.X) * (P0.X - P1.X)) + ((P0.Y - P1.Y) * (P0.Y - P1.Y)));
        }

        void Highlight(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Value.ToString().Length + ((((NumericUpDown)sender).DecimalPlaces > 0) ? ((NumericUpDown)sender).DecimalPlaces + 1 : 0));
        }

        #endregion
    }
}