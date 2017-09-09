using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp1
{
    public partial class Form1 : Form
    {
        CoreParameters ParametersApp;
        public Form1()
        {
            InitializeComponent();
            ParametersApp = new CoreParameters();
            
            ParametersApp.QuestionFile = new QuestionsFileLoaderClass(ParametersApp.QuestionsFile);   //  QuestionsFileLoaderClass QuestionFile = new QuestionsFileLoaderClass(QuestionsFile);

            ParametersApp.QuestionList = new List<string>();
            ParametersApp.QuestionList = ParametersApp.QuestionFile.GetQuestionsList();         // QuestionList = QuestionFile.GetQuestionsList();

            ParametersApp.TesterLogic = new TesterClass(ParametersApp.QuestionList);  //   TesterClass TesterLogic = new TesterClass(QuestionList);

            FormQuestion_1.Text = ParametersApp.TesterLogic.QuestionObtainVariant1();
            FormQuestion_2.Text = ParametersApp.TesterLogic.QuestionObtainVariant2();
        }

        private void richTextBox1Variant1Area_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Обновление параметров на форме
        private void UpdateParametersShow()
        {
            label4Extroverted.Text = "Extroverted(E): " + ParametersApp.TesterLogic.ResultExtroverted;
            label5Introverted.Text = "Introverted(I): " + ParametersApp.TesterLogic.ResultIntroverted;
            label6Sensing.Text = "Sensing(S): " + ParametersApp.TesterLogic.ResultSensing;
            label7Intuitive.Text = "Intuitive(N): " + ParametersApp.TesterLogic.ResultIntuitive;
            label8Irrational.Text = "Irrational(Irr): " + ParametersApp.TesterLogic.ResultIrrational;
            label8Logic.Text = "Logic(L): " + ParametersApp.TesterLogic.ResultLogic;
            label9Ethics.Text = "Ethics(Et): " + ParametersApp.TesterLogic.ResultEthics;
            label10Rational.Text = "Rational(R): " + ParametersApp.TesterLogic.ResultRational;
            label3ProgressCounter.Text = "Общий прогресс = " + ParametersApp.TesterLogic.ResultProgressTest + "%";
            label11TypePerson.Text = "Итог теста = " + ParametersApp.TesterLogic.TestPsychotype;
        }


        private void button1Variant1_Click(object sender, EventArgs e)
        {
            FormQuestion_1.Text = ParametersApp.TesterLogic.QuestionObtainVariant1();
            FormQuestion_2.Text = ParametersApp.TesterLogic.QuestionObtainVariant2();
            ParametersApp.TesterLogic.ParametersTestCountVariant1();
            UpdateParametersShow();

            if (ParametersApp.TesterLogic.ButtonVariantFlag == true)
            {
                button1Variant1.Enabled = false;
                button2Variant2.Enabled = false;
            }
           
        }

        private void button2Variant2_Click(object sender, EventArgs e)
        {
            FormQuestion_1.Text = ParametersApp.TesterLogic.QuestionObtainVariant1();
            FormQuestion_2.Text = ParametersApp.TesterLogic.QuestionObtainVariant2();
            ParametersApp.TesterLogic.ParametersTestCountVariant2();
            UpdateParametersShow();

            if (ParametersApp.TesterLogic.ButtonVariantFlag == true)
            {
                button1Variant1.Enabled = false;
                button2Variant2.Enabled = false;
            }
        }
    }
}
