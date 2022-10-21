using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishPopUpQuiz
{
    public partial class AddWord : Form
    {

        private clsFileProcesses fp;

        public AddWord()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fp = new clsFileProcesses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string English = txtIngilizce.Text, Turkish = txtTurkce.Text;

            fp.WriteFile(English,Turkish);
        }

        private void AddWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
