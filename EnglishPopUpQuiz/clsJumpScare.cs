using System;
using System.Media;
using AudioSwitcher.AudioApi.CoreAudio;

namespace EnglishPopUpQuiz
{
    public class clsJumpScare
    {
        private JumpScare _jumpscare;
        CoreAudioDevice defaultPlaybackDevice;
        
        public clsJumpScare(JumpScare _jumpscare)
        {
            this._jumpscare = _jumpscare;
            

            string sFilePath = "Korkunc.jpg";
            SoundPlayer sp = new SoundPlayer("korkunc.wav");

            defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Mute(false);
            defaultPlaybackDevice.Volume = 15;

            this._jumpscare.tmrJumpScare.Enabled = true;
            _jumpscare.pictureBox1.WaitOnLoad = false;
            this._jumpscare.pictureBox1.LoadAsync(sFilePath);
            sp.Play();

            _jumpscare.tmrJumpScare.Tick += TmrJumpScare_Tick;
            this._jumpscare.Show();
        }

        private void TmrJumpScare_Tick(object sender, EventArgs e)
        {
            _jumpscare.Hide();
            defaultPlaybackDevice.Volume = 10;
            _jumpscare.tmrJumpScare.Enabled = false;
        }
    }
}
