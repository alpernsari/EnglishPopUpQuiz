using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPopUpQuiz
{
    public class clsFileProcesses
    {
        //List<string> _lWords = new List<string>();
        private string _sFilePath = "Words.txt";
        string[] _lWords;
        int _iRowCount;
        public clsFileProcesses()
        {
            _iRowCount= File.ReadAllLines(_sFilePath).Length; 
            using(StreamReader sr = new StreamReader(_sFilePath))
            { 
                _lWords = new string[iRowCount];
            
                for (int i = 0; i < iRowCount; i++)
                {
                    _lWords[i] = sr.ReadLine();
                }
            }

            
        }

        public string[] lWords { get { return _lWords; }}

        public string sFilePath  { get { return _sFilePath; } }

        public int iRowCount { get { return _iRowCount; } }
    }
}
