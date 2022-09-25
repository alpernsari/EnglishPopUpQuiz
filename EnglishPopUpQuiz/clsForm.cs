using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPopUpQuiz
{
    public class clsForm
    {
        private Form1 _form1;
        private List<string> Turkish;
        private List<string> English;
        private clsFileProcesses _FileProcces;
        private JumpScare js;
        private clsJumpScare _jumpscare;
        private Random _rand;
        private int _iQuestionIndex;
        private int[] _iMinAndMaxTime;
        public clsForm(Form1 Form1)
        {
            int screenwidth = Screen.PrimaryScreen.Bounds.Size.Width;
            int formwidth = Form1.Width;
            Form1.Location = new Point(screenwidth - formwidth, 0);

            _FileProcces = new clsFileProcesses();
            js = new JumpScare();
            _rand = new Random();
            Turkish = new List<string>();
            English = new List<string>();
            _iMinAndMaxTime = new int[2];

            _form1 = Form1;
            _iMinAndMaxTime[0] = 5000;//300000 -> 5 dakika
            _iMinAndMaxTime[1] = 20000;//600000 -> 10 dakika
            _form1.Hide();

            string[] _lWords = _FileProcces.lWords;
            FormatTheArray(_lWords);

            _form1.tmrTimer.Interval = 1;
            _form1.tmrTimer.Enabled = true;


            _form1.tmrTimer.Tick += TmrTimer_Tick;
            _form1.btnAnswer1.Click += BtnAnswer1_Click;
            _form1.btnAnswer2.Click += BtnAnswer2_Click;
            _form1.btnAnswer3.Click += BtnAnswer3_Click;
            _form1.btnAnswer4.Click += BtnAnswer4_Click;
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
    
        private int CreateRandomNumber()
        {
            
            int iQuestionIndex = _rand.Next(_FileProcces.iRowCount);
            //MessageBox.Show(iQuestionNumber.ToString);
            return iQuestionIndex;
        }

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
