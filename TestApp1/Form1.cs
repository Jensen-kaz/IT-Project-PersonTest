using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp1.Core;


namespace TestApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  #region getRichtextBox
        public RichTextBox getRichTextBoxVariantArea()
        {
            return richTextBox1Variant1Area;
        }

        public RichTextBox getRichTextBoxVariant2Area()
        {
            return richTextBox2Variant2Area;
        }

        public RichTextBox getRichTextBoxPersonDescription()
        {
            return richTextBox1PersonDescription;
        }



        #endregion

     

        QuestionLogic QuestionLogicShow = new QuestionLogic(); // вывод вопросов

        private void button1Variant1_Click(object sender, EventArgs e)
        {
            richTextBox1Variant1Area.Text += QuestionLogicShow.QuestionLogicObtainVariant1(/*List*/);
        }

        private void button2Variant2_Click(object sender, EventArgs e)
        {
            richTextBox2Variant2Area.Text += QuestionLogicShow.QuestionLogicObtainVariant2(/*List*/);
        }
    }
}
