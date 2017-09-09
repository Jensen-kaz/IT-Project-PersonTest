using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    //Класс содержит параметры необходимые для работы программы

    class CoreParameters
    {
        private string questionsFile = "data/questions.txt";
        public string QuestionsFile
        {
            get { return questionsFile; }
        }

        public List<string> QuestionList { get; set; }

       public QuestionsFileLoaderClass QuestionFile { get; set; }
       public TesterClass TesterLogic { get; set; }



    }
}
