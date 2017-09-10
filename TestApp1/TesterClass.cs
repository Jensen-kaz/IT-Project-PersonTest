using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    /// <summary>
    ///  Класс TesterClass реализует логику подчёта.
    /// </summary>
    class TesterClass
    {
        /// <summary>
        /// Конструктор класса TesterClass.
        /// </summary>
        /// <param name="AnswerList">Аргумент конструктора - List<string> ответов.</param>
        /// 

        List<string> QuestionList = new List<string>();
        private int questionTotal;                       // Всего вопросов

        public TesterClass(List<string> AnswerList)
        {
            QuestionList = AnswerList;
            questionTotal = QuestionList.Count();
        }

        private int resultProgressTest;   // прогресс теста
        public int ResultProgressTest    
        {
            get
            { return resultProgressTest; }

            private set
            {
                if (value > 0)
                { resultProgressTest = value; }
            }
        } 
        public bool ButtonVariantFlag { get; private set; } // для отключения кнопок при завершении теста

        public string TestPsychotype { get; private set; } // психотип, итог теста

        private int numberQuestion = 0;     // для хранения номера вопроса
        

        #region parametersTest 

        private int extroverted = 0;
        public int Extroverted
        {
            get
            {
                return extroverted;
            }
            private set
            {
                extroverted = value;
            }
        }


        private int introverted = 0;
        public int Introverted
        {
            get
            { return introverted; }

            private set
            {
                introverted = value;
            }
        }


        private int sensing = 0;
        public int Sensing
        {
            get
            { return sensing; }

            private set
            { sensing = value; }
        }


        private int intuitive = 0;
        public int Intuitive
        {
            get
            { return intuitive; }

            private set
            { intuitive = value; }
        }


        private int irrational = 0;
        public int Irrational
        {
            get
            { return irrational; }

            private set
            { irrational = value; }
        }


        private int logic = 0;
        public int Logic
        {
            get
            { return logic; }

            private set
            { logic = value; }
        }


        private int ethics = 0;
        public int Ethics
        {
            get
            { return ethics; }

            private set
            { ethics = value; }
        }


        private int rational = 0;
        public int Rational
        {
            get
            { return rational; }

            private set
            { rational = value; }
        }

        public int ResultExtroverted { get; private set;}
        public int ResultIntroverted { get; private set; }
        public int ResultSensing { get; private set; }
        public int ResultIntuitive { get; private set; }
        public int ResultIrrational { get; private set; }
        public int ResultLogic { get; private set; }
        public int ResultEthics { get; private set; }
        public int ResultRational { get; private set; }
        #endregion


        // расчет прогресса теста
        private int GetProgressTest(int completedQuestion)
        {
            completedQuestion = completedQuestion * 100 / questionTotal;
            return completedQuestion;
        }

        // вывод вопросов на форму
        public string QuestionObtainVariant1()
        {
            if (numberQuestion != 0 && numberQuestion < 48)
            {
                numberQuestion++;
                ResultProgressTest= GetProgressTest(numberQuestion);
            }

            if (numberQuestion == 48)
            {
                ButtonVariantFlag = true;
                GetResultTest(ResultExtroverted, ResultIntroverted, ResultRational, ResultIrrational, ResultSensing, ResultIntuitive, ResultLogic, ResultEthics);
                return QuestionList[46];
            }
            
           
             return QuestionList[numberQuestion];
        }

        public string QuestionObtainVariant2()
        {
            if (numberQuestion == 48)
            {
                ButtonVariantFlag = true;
                return QuestionList[47];
            }
            numberQuestion++;

            ResultProgressTest = GetProgressTest(numberQuestion);

            return QuestionList[numberQuestion];
        }

        


        // вычисление параметров теста

        private int ResultCountParameters(int parameterTest)
        {
            parameterTest = parameterTest * 100 / questionTotal;
            return parameterTest;
        }

        public void ParametersTestCountVariant1()
        {
            if (numberQuestion < 14)
            {
                Extroverted++;
                ResultExtroverted= ResultCountParameters(Extroverted);
            }

            if (numberQuestion > 13 && numberQuestion < 26)
            {
                Rational++;
                ResultRational = ResultCountParameters(Rational);
            }

            if (numberQuestion > 25 && numberQuestion < 38)
            {
                Sensing++;
                ResultSensing = ResultCountParameters(Sensing);
            }

            if (numberQuestion > 37 && numberQuestion < 49)
            {
                Logic++;
                ResultLogic = ResultCountParameters(Logic);
            }
        }

        public void ParametersTestCountVariant2()
        {
            if (numberQuestion < 14)
            {
                Introverted++;
                ResultIntroverted = ResultCountParameters(Introverted);
            }

            if (numberQuestion > 13 && numberQuestion < 26)
            {
                Irrational++;
                ResultIrrational = ResultCountParameters(Irrational);
            }

            if (numberQuestion > 25 && numberQuestion < 38)
            {
                Intuitive++;
                ResultIntuitive = ResultCountParameters(Intuitive);
            }

            if (numberQuestion > 37 && numberQuestion < 49)
            {
                Ethics++;
                ResultEthics = ResultCountParameters(Ethics);
            }

        }

        private void GetResultTest(int E, int I, int R, int Irr, int S, int N, int L, int Et)
        {
            if (Irr > R)
            {
                if (S > N)
                    TestPsychotype += "Сенсорно-";
                else
                    TestPsychotype += "Интуитивно-";

                if (L > Et)
                    TestPsychotype += "логический";
                else
                    TestPsychotype += "этический";
            }
            else
            {
                if (L > Et)
                    TestPsychotype += "Логико-";
                else
                    TestPsychotype += "Этико-";

                if (S > N)
                    TestPsychotype += "сенсорный";
                else
                    TestPsychotype += "интуитивный";
            }

            if (E > I)
                TestPsychotype += " экстраверт";
            else
                TestPsychotype += " интроверт";

            
        }

    }
}
