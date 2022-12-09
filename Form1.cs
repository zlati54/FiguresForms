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

            Random random = new Random();
            
            Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
            Graphics g = this.CreateGraphics();
            Point[] trianglePoints = { new Point(50, 50), new Point(200, 50), new Point(125, 200) };
            g.DrawPolygon(pen, trianglePoints);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {

        }

        public void RectangleThread()
        {


        }



    }


}
