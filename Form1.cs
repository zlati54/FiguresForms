namespace FiguresForms
{
    public partial class Form1 : Form
    {
        Thread thread1;
        Thread thread2;
        Thread thread3;
        public Form1()
        {
            InitializeComponent();
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
        public void TriangleThread()
        {
            while (true)
            {
                //Coordinates are reverse
                Random random = new Random();
                int cordHeight = random.Next(0, this.Height - 50);
                int cordWidth = random.Next(0, this.Width - 50);
                int sizeHeight = cordHeight + random.Next(50, 150);
                int sizeWidth = cordWidth - random.Next(75, 150);
                Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                Graphics g = this.CreateGraphics();
                Point[] trianglePoints = { new Point(sizeWidth + random.Next(150, 250), sizeHeight), new Point(cordWidth, cordHeight), new Point(sizeWidth, sizeHeight) };
                g.DrawPolygon(pen, trianglePoints);
                Thread.Sleep(2000);
            }
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {

        }

        public void RectangleThread()
        {

            while (true)
            {
                Random random = new Random();
                Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                Graphics g = this.CreateGraphics();
                int cordHeight = random.Next(0, this.Height - 155);
                int cordWidth = random.Next(0, this.Width - 155);
                int sizeHeight = random.Next(50, 150);
                int sizeWidth = random.Next(50, 150);
                g.DrawRectangle(pen, cordWidth, cordHeight, sizeWidth, sizeHeight);
                Thread.Sleep(3000);
            }
            


        }



    }


}
