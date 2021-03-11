using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicEditor
{
    enum DrawMode
    {
        LINE,
        RECTANGLE,
        CIRCLE,
        CURVED_LINE
    }
    public partial class FrmMain : Form
    {
        private DrawMode mode;
        private Graphics g;
        private Pen pen;
        private Pen eraser;
        private Point startP, endP, currP, preP;

        

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StsCurved.Text = "";

            g = CreateGraphics();
            pen = new Pen(Color.Black, 2);
            StsCurved.Text = "Line Mode";
            this.BackColor = Color.White;
            this.eraser = new Pen(Color.White, 2);
        }

        private void TlmLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.LINE;
            StsCurved.Text = "Line Mode";
        }

        

        private void TlmRectangle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.RECTANGLE;
            StsCurved.Text = "Rectangle Mode";
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.startP = new Point(e.X, e.Y);//그냥 이벤트가 아니라 마우스이벤트의 e값이기 때문에 x,y를 가지고 있다
            this.currP = this.preP = this.startP; 
        }

        /// <summary>
        /// 마우스 옮길때마다 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            this.preP = this.currP;
            this.currP = new Point(e.X, e.Y);

            switch (this.mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(this.eraser, this.startP, this.preP);
                    g.DrawLine(this.pen, this.startP, this.currP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.eraser, new Rectangle(startP, new Size(preP.X-startP.Y,preP.Y-startP.Y)));
                    g.DrawRectangle(this.pen, new Rectangle(startP, new Size(currP.X - startP.Y, currP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.eraser, new Rectangle(startP, new Size(preP.X - startP.Y, preP.Y - startP.Y)));
                    g.DrawEllipse(this.pen, new Rectangle(startP, new Size(currP.X - startP.Y, currP.Y - startP.Y)));
                    break;
                   
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.endP = new Point(e.X, e.Y);
            switch (this.mode)
            {
                case DrawMode.LINE:
                    g.DrawLine(this.pen, this.startP, this.endP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.pen, new Rectangle(startP, new Size(endP.X - startP.Y, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.pen, new Rectangle(startP, new Size(endP.X - startP.Y, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }

        private void TlmCircle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CIRCLE;
            StsCurved.Text = "Circle Mode";
        }

        private void TlmCurvedLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CURVED_LINE;
            StsCurved.Text = "Curvedline Mode";

        }

        private void TlmColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pen.Color = dialog.Color;
            }
        }
    }
}
