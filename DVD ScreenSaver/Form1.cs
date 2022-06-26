namespace DVD_ScreenSaver
{
    public partial class Form1 : Form
    {
        //create the sprite
        private int dvdWidth = 256;
        private int dvdHeight = 123;
        private int ballPosX = 0;
        private int ballPosY = 0;

        private int moveStepX = 4;
        private int moveStepY = 4;

        private Random r = new Random();

        private PictureBox pictureBox1 = new PictureBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ImageLocation = @"E:\Project\DVD-ScreenSaver\DVD ScreenSaver\DVD ScreenSaver\Image\dvd_logo.png";
            pictureBox1.Location = new Point(ballPosX, ballPosY);
            pictureBox1.Name = "pictureBox2";
            pictureBox1.Size = new Size(dvdWidth, dvdHeight);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Controls.Add(pictureBox1);
            pictureBox1.BringToFront();
        
        }  
        private void Move_Logo(object sender, EventArgs e)
        {
            //update position
            ballPosX += moveStepX;
            if (ballPosX < 0 || ballPosX + dvdWidth > this.ClientSize.Width)
            {
                moveStepX = -moveStepX;
                pictureBox1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                //pictureBox1.Image = pictureBox1.Image.ColourFilter();

            }
            ballPosY += moveStepY;
            if (ballPosY < 0 || ballPosY + dvdHeight > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
                pictureBox1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                //pictureBox1.Image = pictureBox1.Image.ColourFilter();
            }
            pictureBox1.Location = new Point(ballPosX, ballPosY);
            
            //update logo
            this.Refresh();
        }
    }
}