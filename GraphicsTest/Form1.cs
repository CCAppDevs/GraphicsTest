namespace GraphicsTest
{
    public partial class Form1 : Form
    {
        private Pen BlackPen;
        private SolidBrush YellowBrush;
        private SolidBrush BrownBrush;
        private Image CharacterImage;
        private string ImagesPath; // where our images are stored

        private int _posX;
        private int _posY;

        public int PosX
        {
            get
            {
                return _posX;
            }
            set
            {
                int val = value;

                if (_posX + val < 0)
                {
                    val = 0;
                }
                else if (_posX + val > this.Width)
                {
                    val = this.Width;
                }

                _posX = val;
            }
        }

        public int PosY
        {
            get
            {
                return _posY;
            }
            set
            {
                int val = value;

                if (_posY + val < 0)
                {
                    val = 0;
                }
                else if (_posY + val > this.Height)
                {
                    val = this.Height;
                }
                
                _posY = val;
            }
        }

        private int Speed;

        public Form1()
        {
            InitializeComponent();
            BlackPen = new Pen(Color.Black);
            YellowBrush = new SolidBrush(Color.LightGoldenrodYellow);
            BrownBrush = new SolidBrush(Color.SandyBrown);

            PosX = 300;
            PosY = 30;
            Speed = 10;

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

            Font font = new Font(SystemFonts.DefaultFont.FontFamily, 14, FontStyle.Regular);
            e.Graphics.DrawString($"PosX: {PosX}, PosY {PosY}", font, YellowBrush, new Point(this.Width - 300, this.Height - 300));
        }

        private void MoveRight(int amount)
        {
            PosX += amount;
        }

        private void MoveDown(int amount)
        {
            PosY += amount;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // check if a key is pressed and it is a w, a, s, or d
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                MoveRight(Speed);
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                MoveRight(-Speed);
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                MoveDown(Speed);
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                MoveDown(-Speed);
            }

            Invalidate();
        }
    }
}
