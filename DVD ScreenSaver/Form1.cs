namespace DVD_ScreenSaver
{
    public partial class Form1 : Form
    {
        //create the sprite
        private int dvdWidth = 300;
        private int dvdHeight = 150;
        private int ballPosX = 0;
        private int ballPosY = 0;

        private int moveStepX = 4;
        private int moveStepY = 4;

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void DVDLogo(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);

            e.Graphics.FillRectangle(Brushes.Red,
                ballPosX, ballPosY,
                dvdWidth, dvdHeight);

            e.Graphics.DrawRectangle(Pens.Black,
                ballPosX, ballPosY,
                dvdWidth,dvdHeight);
        }

        private void Move_Logo(object sender, EventArgs e)
        {
            //update position
            ballPosX += moveStepX;
            if (ballPosX < 0 || ballPosX + dvdWidth > this.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }
            ballPosY += moveStepY;
            if (ballPosY < 0 || ballPosY + dvdHeight > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }
            //update logo
            //this.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}