using System.ComponentModel;
using System.Drawing.Text;
using System.Media;

namespace RandomForUse
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Random random = new Random();
        private int dx = 10; //Increase this value to make button go faster horizontally.
        private int dy = 10; //Increae this value to make button go fatser vertically.
        private System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"D:/.net/RandomForUse/explosion-42132.wav");
        private int tickCount = 0;
        private int originalLeft;
        private int originalTop;
        public Form1()
        {
            InitializeComponent();

            //Stores original postion
            originalLeft = RandomBtn.Left;
            originalTop = RandomBtn.Top;

            RandomBtn.Click += new EventHandler(RandomBtn_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {

            int action = random.Next(1, 4);

            switch(action)
            {
                case 1:
                    MessageBox.Show("HAHAHAHAHAHA!");
                    break;

                case 2:
                    soundPlayer.Stop(); // stops current sound
                    soundPlayer.Play(); //plays a sound
                    break;

                case 3:
                    timer = new System.Windows.Forms.Timer();
                    timer.Interval = 3; //sets the timer to n milliseconds
                    timer.Tick += Timer_Tick; //set the event handler for tick event
                    timer.Start();
                    break;
                    
                case 4:
                    MessageBox.Show("");
                    break;


            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            RandomBtn.Left += dx;
            RandomBtn.Top += dy;

            if(RandomBtn.Left < 0 || RandomBtn.Right > this.ClientSize.Width)
            {
                //reverse the horitzontal direction
                dx = -dx;
            }
            if(RandomBtn.Top < 0 || RandomBtn.Bottom > this.ClientSize.Height)
            {
                //reverse the vertical direction
                dy = -dy;
            }

            //Stop the timer after n ticks
            tickCount++;
            if(tickCount >= 100)
            {
                timer.Stop();
                RandomBtn.Left = originalLeft;
                RandomBtn.Top = originalTop;
            }
        }
    }
}
