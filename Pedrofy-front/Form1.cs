namespace Pedrofy_front
{
    public partial class formPedrofy : Form
    {
        int totalSeconds = 220;
        int actualSeconds = 0;

        public formPedrofy()
        {
            InitializeComponent();
            SyncInterface();

            btnPause.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Visible = false;
            btnPlay.Visible = true;
            timerMusic.Stop();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void formPedrofy_Load(object sender, EventArgs e)
        {

        }

        private void SyncInterface()
        {
            lblTotalMinutes.Text = $"{totalSeconds/60}:{totalSeconds%60}";
            lblActualMinutes.Text = $"{actualSeconds / 60}:{actualSeconds % 60}";
            FillMusicProgressBar();
        }

        private void FillMusicProgressBar()
        {
            int value = Convert.ToInt32(100.0 * actualSeconds / totalSeconds);
            if (value < 0) value = 0;
            if (value > 100) value = 100;
            pbMusicTimer.Value = value;
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            actualSeconds++;
            SyncInterface();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnPause.Visible = true;
            timerMusic.Start();
        }
    }
}