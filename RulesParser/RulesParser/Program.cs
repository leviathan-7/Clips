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
            StreamReader f = new StreamReader("rules.txt");
            while (!f.EndOfStream)
                LST.Add(f.ReadLine());
            f.Close();
            StreamWriter ff = new StreamWriter("rules.clp");
            ff.WriteLine("(deftemplate message");
            ff.WriteLine("	(slot str)");
            ff.WriteLine("	(slot priorites)");
            ff.WriteLine(")");

            foreach (var item in LST)
                StrToClp(item,ff);
            ff.Close();
        }
        static void StrToClp(string str, StreamWriter f)
        {
            string[] Arr = str.Split(':',';');
            f.WriteLine("(defrule " + Arr[0]);
            string[] Arr2 = Arr[1].Split('-', '>');
            string[] Arr3 = Arr2[0].Split(',');
            for (int i = 0; i < Arr3.Length; i++)
                f.WriteLine("	(food (is 1)(id " + MinusF(Arr3[i]) + ")(name ?name" + i + ")(priorites ?priorites" + i + "))");

            f.WriteLine("	?n<- (food (id "+MinusF(Arr2[2])+" ))");
            f.WriteLine("   (food (id " + MinusF(Arr2[2]) + " )(is ?is_ )(name ?nn)(priorites ?pp))");
            f.WriteLine("	=>");

            f.WriteLine("   (bind ?pr ?priorites0)");
            for (int i = 1; i < Arr3.Length; i++)
                f.WriteLine("   (bind ?pr (- (+ ?pr ?priorites" + i + ") (* ?pr ?priorites" + i + ")))");

            f.WriteLine("	(if (and (= ?is_ 1) (> ?pr ?pp))");
            f.WriteLine("	then");
            f.WriteLine("	(modify ?n (priorites ?pr))");
            f.WriteLine("   (assert (message (str ?nn)(priorites ?pr)))");
            f.WriteLine("   )");

            f.WriteLine("	(if (= ?is_ 0)");
            f.WriteLine("	then");
            f.WriteLine("	(modify ?n (is 1 ))");
            f.WriteLine("	(modify ?n (priorites ?pr))");
            f.WriteLine("   (assert (message (str ?nn)(priorites ?pr)))");
            f.WriteLine("   )");

            f.WriteLine(")");
        }
        static string MinusF(string str)
        {
            return str.Split('F')[1];
        }
    }
}
