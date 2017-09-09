using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp1
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         //   string QuestionsFile = "data/questions.txt";
         //   List<string> QuestionList = new List<string>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

       /*     QuestionsFileLoaderClass QuestionFile = new QuestionsFileLoaderClass(QuestionsFile);
            QuestionList= QuestionFile.GetQuestionsList();

            TesterClass TesterLogic = new TesterClass(QuestionList);

             Form1.FormQuestion_1.Text.Insert(0, QuestionFile.GetQuestionsList()[4]); 
       */
            

        }
    }
}
