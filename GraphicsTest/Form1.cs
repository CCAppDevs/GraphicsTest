namespace GraphicsTest
{
    public partial class Form1 : Form
    {
        private Pen BlackPen;
        private SolidBrush YellowBrush;
        private SolidBrush BrownBrush;
        private Image CharacterImage;
        private string ImagesPath; // where our images are stored

        private int PosX;
        private int PosY;
        private int Speed;

        public Form1()
        {
            InitializeComponent();
            BlackPen = new Pen(Color.Black);
            YellowBrush = new SolidBrush(Color.LightGoldenrodYellow);
            BrownBrush = new SolidBrush(Color.SandyBrown);

            PosX = 300;
            PosY = 300;
            Speed = 5;

            ImagesPath = Path.Combine(Environment.CurrentDirectory, "Images");
            CharacterImage = Image.FromFile(Path.Combine(ImagesPath, "Dude_Monster.png"));
        }

        private void DrawFrame(object sender, PaintEventArgs e)
        {
            // draw ground
            Rectangle Sun = new Rectangle(50, 50, 100, 100);
            Rectangle Ground = new Rectangle(
                0,
                this.Height - 100,
                this.Width,
                100
            );

            e.Graphics.FillRectangle(BrownBrush, Ground);

            // Draw sun
            e.Graphics.FillEllipse(YellowBrush, Sun);

            // draw a character
            e.Graphics.DrawImage(CharacterImage, PosX, PosY);
        }

        private void MoveRight(int amount)
        {
            PosX += Speed;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // check if a key is pressed and it is a w, a, s, or d
            if (e.KeyCode == Keys.D)
            {
                MoveRight(Speed);
            }

            if (e.KeyCode == Keys.A)
            {
                MoveRight(-Speed);
            }

            Invalidate();
        }
    }
}
