using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp1;

namespace TestApp1.Core
{
    class QuestionLogic
    {


        private int i = 0;
   //     private string variant1;
  //      private string variant2;
       

        public string QuestionLogicObtainVariant1(List<string> QuestionList)
        {
            if (i != 0)
            { i++; }
            
            return QuestionList[i];
            
        }

        public string QuestionLogicObtainVariant2(List<string> QuestionList)
        {
            i++;
            return QuestionList[i];
        }

    }
}
