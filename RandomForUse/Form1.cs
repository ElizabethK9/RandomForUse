using System.ComponentModel;
using System.Media;

namespace RandomForUse
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Random random = new Random();
        private int dx = 10; //Increase this value to make button go faster horizontally.
        private int dy = 10; //Increae this value to make button go fatser vertically.
        private System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer("explosion-42132(2).wav");
        public Form1()
        {
            InitializeComponent();

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
                    timer.Interval = 50; //sets the timer to n milliseconds
                    timer.Tick += Timer_Tick; //set the event handler for tick event
                    timer.Start();
                    break;
                    
                case 4:
                    MessageBox.Show();
                    break;


            }

        }
    }
}
