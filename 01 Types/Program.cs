using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Types
{
    class Program
    {

        static string ClassTitle { get; set; }

        /// <summary>
        /// Dit is je main method, deze start in een console automatisch
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Rekenen.Reken1();
            Console.ReadKey();

        }

        public static void NogEenMethod()
        {
       
            ClassTitle = "andere niewue waarde";
            Console.WriteLine(ClassTitle);
        }
        public static void opdracht1()
        {

            // op method niveau defineer je een type van het type string
            // en deze string geven wij een voorgedifineerde waarde.
            string Title = "Dit is de titel van mijn applicatie";

            ClassTitle = Title + " Extra woorden";


            Console.WriteLine(Title);
            Console.WriteLine("-----------");
            Console.WriteLine(ClassTitle);

            NogEenMethod();

            NewClass NewClass = new NewClass();

            NewClass.ClassTitle = "niewe waarde 0";
            NewClass.ClassTitle2 = "niewe waarde 1";
            NewClass.ClassTitle3 = "niewe waarde 2";
            NewClass.Classinterger = 1;
            NewClass.TrueOrFalse = true;
            NewClass.Now = DateTime.Now;


            Console.WriteLine("-----------");

            Console.WriteLine("Eerste waarde {0} : tweede waarde {1} derde waarde {2} vierdewaarde {3} vijfde {4} zesde {5} realtime {6}", NewClass.ClassTitle, NewClass.ClassTitle2, NewClass.ClassTitle3, NewClass.Classinterger, NewClass.TrueOrFalse, NewClass.Now, DateTime.Now);

            Console.WriteLine("-----------");
            List<NewClass> NewClass2 = new List<NewClass>();

            NewClass2.Add(new NewClass { ClassTitle = "hallo", ClassTitle2 = "regel 1", ClassTitle3 = "regel nog iest" });
            NewClass2.Add(new NewClass { ClassTitle = "hallo1", ClassTitle2 = "regel 2", ClassTitle3 = "regel nog iest sd" });
            NewClass2.Add(new NewClass { ClassTitle = "hallo2", ClassTitle2 = "regel 3", ClassTitle3 = "regel nog iest xa" });

            int counter = 0;

            foreach (var item in NewClass2)
            {
                counter++;
                Console.WriteLine(counter + "-----------");
                Console.WriteLine(item.ClassTitle);
                Console.WriteLine(item.ClassTitle2);
                Console.WriteLine(item.ClassTitle3);
            }




        }
    }
}

