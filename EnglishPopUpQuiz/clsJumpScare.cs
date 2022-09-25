using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using AudioSwitcher.AudioApi.CoreAudio;

namespace EnglishPopUpQuiz
{
    public class clsJumpScare
    {
        private JumpScare _jumpscare;
        public clsJumpScare(JumpScare _jumpscare)
        {
            this._jumpscare = _jumpscare;
            this._jumpscare.Show();

            string sFilePath = "Korkunc.jpg";
            SoundPlayer sp = new SoundPlayer("korkunc.wav");

            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Volume = 10;

            this._jumpscare.tmrJumpScare.Enabled = true;
            this._jumpscare.pictureBox1.ImageLocation = sFilePath;
            sp.Play();

            _jumpscare.tmrJumpScare.Tick += TmrJumpScare_Tick;
        }

        private void TmrJumpScare_Tick(object sender, EventArgs e)
        {
            _jumpscare.Hide();
            _jumpscare.tmrJumpScare.Enabled = false;
        }
    }
}
