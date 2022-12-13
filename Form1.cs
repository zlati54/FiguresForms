namespace FiguresForms
{
    public partial class Form1 : Form
    {
        Thread thread1;
        Thread thread2;
        Thread thread3;
        int shapesNumber = 0;
        bool stop = false;
        bool isWhiteTheme = true;

        public Form1()
        {
            InitializeComponent();
        }

        public void SetShapesNumber()
        {
            lblNumberOfFigures.Text = "Rendered figures: " + shapesNumber;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(RectangleThread);
            thread1.Start();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(TriangleThread);
            thread2.Start();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            thread3 = new Thread(CircleThread);
            thread3.Start();
        }

        public void TriangleThread()
        {
            while (true && stop == false)
            {
                //Coordinates are reverse
                Random random = new Random();
                int cordHeight = random.Next(0, this.Height - 155);
                int cordWidth = random.Next(0, this.Width - 155);
                int sizeHeight = cordHeight + random.Next(50, 150);
                int sizeWidth = cordWidth + random.Next(75, 150);
                Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                Graphics g = this.CreateGraphics();
                Point[] trianglePoints =
                {
                    new Point(Math.Max(0, cordWidth - random.Next(150, 250)), sizeHeight),
                    new Point(cordWidth, cordHeight), new Point(sizeWidth, sizeHeight)
                };
                g.DrawPolygon(pen, trianglePoints);
                shapesNumber++;
                SetShapesNumber();
                Thread.Sleep(2000);
            }
        }

        public void CircleThread()
        {
            while (true && stop == false)
            {
                Random random = new Random();
                Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                Graphics g = this.CreateGraphics();
                int cordHeight = random.Next(0, this.Height - 155);
                int cordWidth = random.Next(0, this.Width - 155);
                int sizeHeight = random.Next(50, 150);
                int sizeWidth = random.Next(50, 150);
                g.DrawEllipse(pen, cordWidth, cordHeight, sizeWidth, sizeHeight);
                shapesNumber++;
                SetShapesNumber();
                Thread.Sleep(4000);
            }
        }

        public void RectangleThread()
        {
            while (true && stop == false)
            {
                Random random = new Random();
                Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                Graphics g = this.CreateGraphics();
                int cordHeight = random.Next(0, this.Height - 155);
                int cordWidth = random.Next(0, this.Width - 155);
                int sizeHeight = random.Next(50, 150);
                int sizeWidth = random.Next(50, 150);
                g.DrawRectangle(pen, cordWidth, cordHeight, sizeWidth, sizeHeight);
                shapesNumber++;
                SetShapesNumber();
                Thread.Sleep(3000);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (stop == false)
            {
                stop = true;
                btnStop.Text = "start";
            }
            else if (stop == true)
            {
                stop = false;
                btnStop.Text = "stop";
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (isWhiteTheme == true)
            {
                btnCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));
                btnCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));

                btnRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));
                btnRectangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));

                btnTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));
                btnTriangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));

                btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));
                btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));

                btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));
                btnTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));

                lblNumberOfFigures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))),
                    ((int)(((byte)(28)))), ((int)(((byte)(28)))));
                lblNumberOfFigures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))),
                    ((int)(((byte)(243)))), ((int)(((byte)(243)))));

                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))),
                    ((int)(((byte)(18)))));

                isWhiteTheme = false;
                btnTheme.Text = "white theme";
            }
            else
            {
                btnCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));
                btnCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));

                btnRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));
                btnRectangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));

                btnTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));
                btnTriangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));

                btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));
                btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));

                btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))),
                    ((int)(((byte)(243)))));
                btnTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))),
                    ((int)(((byte)(28)))));

                lblNumberOfFigures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))),
                    ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                lblNumberOfFigures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))),
                    ((int)(((byte)(28)))), ((int)(((byte)(28)))));

                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))),
                    ((int)(((byte)(238)))));
                isWhiteTheme = true;
                btnTheme.Text = "dark theme";
            }
        }
    }
}
