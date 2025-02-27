namespace GraphicsTest
{
    public partial class Form1 : Form
    {
        private Pen BlackPen;
        private SolidBrush YellowBrush;
        private SolidBrush BrownBrush;

        public Form1()
        {
            InitializeComponent();
            BlackPen = new Pen(Color.Black);
            YellowBrush = new SolidBrush(Color.LightGoldenrodYellow);
            BrownBrush = new SolidBrush(Color.SandyBrown);
        }

        private void DrawFrame(object sender, PaintEventArgs e)
        {


            // draw square
            //e.Graphics.DrawRectangle(
            //    BlackPen,   // Line Color
            //    (this.Width / 2) - 50, // Start x
            //    (this.Height / 2) - 50, // Start y
            //    100, // width
            //    100 // height
            //);

            // draw filled rectangle
            Rectangle Sun = new Rectangle(50, 50, 100, 100);
            Rectangle Ground = new Rectangle(
                0,
                this.Height - 100,
                this.Width,
                100
            );

            e.Graphics.FillRectangle(BrownBrush, Ground);

            // draw lines
            //e.Graphics.DrawLine(BlackPen, 0, 0, this.Width / 2, this.Height / 2);

            // circles
            e.Graphics.FillEllipse(YellowBrush, Sun);
        }
    }
}
