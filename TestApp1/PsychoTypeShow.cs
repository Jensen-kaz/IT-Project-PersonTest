using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class PsychoTypeShow
    {
     //   string psychoTypeResult;
     //   string pathFile;

        List<string> listPsychotype = new List<string>();
        List<string> listdescription = new List<string>();

       public string PsychotypeDescription { get; private set; }

        public PsychoTypeShow(string psychotypePath)
        {
             
            string line;
            
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(psychotypePath);
                while ((line = sr.ReadLine()) != null)
                {
                    listPsychotype.Add(line);
                }

                sr.Close();
             }
            catch
            {
                System.Console.WriteLine("Error during load file");
            }
        }



        public string GetPsychotypeDescription(string psychotype)
        {
            string description="";
            string splitValue = "###";

            for (int i = 0; i <listPsychotype.Count(); i++)
            {
                if (listPsychotype[i] != splitValue)
                {
                    description += listPsychotype[i] + "\n";
                }
                else
                {
                    listdescription.Add(description);
                    description = "";
                }

            }

            for (int i = 0; i < listdescription.Count(); i++)
            {
                if (listdescription[i].Contains(psychotype))
                    PsychotypeDescription = listdescription[i];    
            }

            return PsychotypeDescription;
        }

        
    }
}
