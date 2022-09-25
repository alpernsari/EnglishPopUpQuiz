using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPopUpQuiz
{
    public class clsSettings
    {
        private Form1 _form1;
        private List<string> Turkish;
        private List<string> English;
        private clsFileProcesses _FileProcces;
        private Random rand;
        public clsSettings(Form1 Form1)
        {
            _FileProcces = new clsFileProcesses();
            rand = new Random();
            Turkish = new List<string>();
            English = new List<string>();
            _form1 = Form1;
            //_form1.Hide();

            string[] _lWords = _FileProcces.lWords;
            FormatTheArray(_lWords);

            foreach (var item in English)
            {
                _form1.listView1.Items.Add(item);
            }

            foreach (var item in Turkish)
            {
                _form1.listView1.Items.Add(item);
            }

            _form1.tmrTimer.Interval = 3000;
            _form1.tmrTimer.Enabled = true;
            _form1.tmrTimer.Tick += TmrTimer_Tick;
        }

        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            //_form1.Show();
            ShowQuestion();
            _form1.tmrTimer.Interval = rand.Next(1000, 10000);
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
            
            int iQuestionIndex = rand.Next(_FileProcces.iRowCount);
            //MessageBox.Show(iQuestionNumber.ToString);
            return iQuestionIndex;
        }

        public void ShowQuestion()
        {
            int iQuestionIndex = CreateRandomNumber();
            int[] QuestionIndexes = new int[3];
            for (int i = 0; i <= 2 ; i++) { QuestionIndexes[i] = CreateRandomNumber(); }
            
            _form1.lblQuestion.Text = English[iQuestionIndex];

            
            int iRandomNumberForAnswersPlace = rand.Next(1,5);

            switch (iRandomNumberForAnswersPlace)
            {
                case 1:
                    _form1.btnAnswer1.Text = Turkish[iQuestionIndex];
                    _form1.btnAnswer2.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer3.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer4.Text = Turkish[QuestionIndexes[2]];
                    break;

                case 2:
                    _form1.btnAnswer1.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer2.Text = Turkish[iQuestionIndex];
                    _form1.btnAnswer3.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer4.Text = Turkish[QuestionIndexes[2]];
                    break;

                case 3:
                    _form1.btnAnswer1.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer2.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer3.Text = Turkish[iQuestionIndex];
                    _form1.btnAnswer4.Text = Turkish[QuestionIndexes[2]];
                    break;

                case 4:
                    _form1.btnAnswer1.Text = Turkish[QuestionIndexes[0]];
                    _form1.btnAnswer2.Text = Turkish[QuestionIndexes[1]];
                    _form1.btnAnswer3.Text = Turkish[QuestionIndexes[2]];
                    _form1.btnAnswer4.Text = Turkish[iQuestionIndex];
                    break;

                default:
                    break;
            }

        }

    }
}
