using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactsParser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> LST = new List<string> { };
            StreamReader f = new StreamReader("facts.txt");
            while (!f.EndOfStream)
                LST.Add(f.ReadLine());
            f.Close();
            StreamWriter ff = new StreamWriter("facts.clp");
            ff.WriteLine("(deftemplate food");
            ff.WriteLine("	(slot is)");
            ff.WriteLine("	(slot id)");
            ff.WriteLine("	(slot name)");
            ff.WriteLine("	(slot priorites)");
            ff.WriteLine(")");
            ff.WriteLine("(deffacts foods");
            Random rnd = new Random();
            foreach (var item in LST)
                ff.WriteLine(StrToClp(item,rnd));
            ff.WriteLine(")");
            ff.Close();
        }
        static string StrToClp(string str, Random rnd)
        {
            string[] Arr = str.Split('F', ':', ';');
            double d = rnd.Next(0, 10) / 10.0;
            string s = "    (food (is 0)(id " + Arr[1] + ") (name " + MinusProbel(Arr[2]) + " )(priorites " + d + "))";
            return s.Replace(',', '.');
        }
        static string MinusProbel(string str)
        {
            string[] Arr = str.Split(' ');
            bool b = true;
            foreach (var item in Arr)
                if (item!="")
                    if (b)
                    {
                        str = item;
                        b = false;
                    }
                    else
                        str += "_" + item;
            return str;
        }
    }
}
