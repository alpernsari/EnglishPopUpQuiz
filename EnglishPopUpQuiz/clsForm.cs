using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;

namespace EnglishPopUpQuiz
{
    public class clsForm
    {
        //Global Değişken tanımlamaları

        private AnaSayfa _form1;
        private List<string> Turkish;
        private List<string> English;
        private clsFileProcesses _FileProcces;
        private JumpScare js;
        private clsJumpScare _jumpscare;
        private Random _rand;
        private AddWord aw;
        private int _iQuestionIndex;
        private int[] _iMinAndMaxTime;


        public clsForm(AnaSayfa Form1)
        {   //Uygulamanın windows başlatıldığı anda başlamasını sağlayan script
            /*RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("English PopUp", Application.ExecutablePath.ToString());*/

            // PopUp'ın köşelerini yumuşatma
            int screenwidth = Screen.PrimaryScreen.Bounds.Size.Width;
            int formwidth = Form1.Width;
            Form1.Location = new Point(screenwidth - formwidth, 0);

            //çeşitli classları türetme
            _FileProcces = new clsFileProcesses();
            _FileProcces.ReadFile();
            js = new JumpScare();
            _rand = new Random();
            Turkish = new List<string>();
            English = new List<string>();
            _iMinAndMaxTime = new int[2];

            /*form uygulamamızı türetme ve PopUp'ın ekranda rastgele belirmesi için minimum ve 
                maksimum değer*/
            _form1 = Form1;
            aw = new AddWord();
            _iMinAndMaxTime[0] = 300000;//300000 -> 5 dakika
            _iMinAndMaxTime[1] = 600000;//600000 -> 10 dakika
            _form1.Hide();

            //FileProcces classından gelen metinden okunmuş kelimeler dizisi
            string[] _lWords = _FileProcces.lWords;
            FormatTheArray(_lWords);

            //Timer objesinin ayarları
            _form1.tmrTimer.Interval = 1;
            _form1.tmrTimer.Enabled = true;

            //Formun olayları

            //timer tick olayı
            _form1.tmrTimer.Tick += TmrTimer_Tick;
            //buttonların olayları
            _form1.btnAddWord.Click += BtnAddWord_Click;
            _form1.btnAnswer1.Click += BtnAnswer1_Click;
            _form1.btnAnswer2.Click += BtnAnswer2_Click;
            _form1.btnAnswer3.Click += BtnAnswer3_Click;
            _form1.btnAnswer4.Click += BtnAnswer4_Click;
        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            aw.Show();
        }

        private void BtnAnswer4_Click(object sender, EventArgs e)
        {

            if (_form1.btnAnswer4.Text == Turkish[_iQuestionIndex])
                _form1.Hide();
            else
                _jumpscare = new clsJumpScare(js);
        }

        private void BtnAnswer3_Click(object sender, EventArgs e)
        {

            if (_form1.btnAnswer3.Text == Turkish[_iQuestionIndex])
                _form1.Hide();
            else
                _jumpscare = new clsJumpScare(js);
        }

        private void BtnAnswer2_Click(object sender, EventArgs e)
        {

            if (_form1.btnAnswer2.Text == Turkish[_iQuestionIndex])
                _form1.Hide();
            else
                _jumpscare = new clsJumpScare(js);
        }

        private void BtnAnswer1_Click(object sender, EventArgs e)
        {
            if (_form1.btnAnswer1.Text == Turkish[_iQuestionIndex])
                _form1.Hide();
            else
                _jumpscare = new clsJumpScare(js);
        }

        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            ShowQuestion();
            _form1.Show();
            _form1.tmrTimer.Interval = _rand.Next(_iMinAndMaxTime[0], _iMinAndMaxTime[1]);
        }
    
        //FileProcces classından gelen diziyi kullanılabilir iki liste haline getirir
        private void FormatTheArray(string[] words)
        {
            foreach (var item in words)
            {
                string[] temp;
                temp = item.Split(',');
                English.Add(temp[0].ToString().Trim());
                Turkish.Add(temp[1].ToString().Trim());
            }

        }
    
        //ingilizce ve türkçe kelimelerin bulunduğu metin dosyasından rastgele bir index seçmeye yarar
        private int CreateRandomNumber()
        {
            
            int iQuestionIndex = _rand.Next(_FileProcces.iRowCount);
            //MessageBox.Show(iQuestionNumber.ToString);
            return iQuestionIndex;
        }

        //Soruyla ilgili detayları hazırlar
        public void ShowQuestion()
        {
            _iQuestionIndex = CreateRandomNumber();
            int[] QuestionIndexes = new int[3];
            for (int i = 0; i <= 2 ; i++) { QuestionIndexes[i] = CreateRandomNumber(); }
            
            _form1.lblQuestion.Text = English[_iQuestionIndex];

            
            int iRandomNumberForAnswersPlace = _rand.Next(1,5);

            switch (iRandomNumberForAnswersPlace)
            {
                case 1:
                    _form1.btnAnswer1.Text = Turkish[_iQuestionIndex];
                    _form1.btnAnswer2.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer3.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer4.Text = Turkish[QuestionIndexes[2]];
                    break;

                case 2:
                    _form1.btnAnswer1.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer2.Text = Turkish[_iQuestionIndex];
                    _form1.btnAnswer3.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer4.Text = Turkish[QuestionIndexes[2]];
                    break;

                case 3:
                    _form1.btnAnswer1.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer2.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer3.Text = Turkish[_iQuestionIndex];
                    _form1.btnAnswer4.Text = Turkish[QuestionIndexes[2]];
                    break;

                case 4:
                    _form1.btnAnswer1.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer2.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer3.Text = Turkish[QuestionIndexes[2]];
                    _form1.btnAnswer4.Text = Turkish[_iQuestionIndex];
                    break;

                default:
                    break;
            }

        }

    }
}
