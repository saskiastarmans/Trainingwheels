using System;

namespace TrainingWheelsStart  // ==> This is the namespace
{
    class Program  // ==> this is your class declaration
    {
        /// <summary>
        /// These are your first lines of code, for now this is all you need to now
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) // ==> This is your method declaration (starts automatically when hittin F5)
        {
            FirstProgram();  // ==> this is a call to a other Method (we run the function on a other location)

            // the console will only be closed when a key (on the keyboard) is hit
            // If we do not use this statement, we will not see the solution (windows opens en closes again)
            Console.ReadKey();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        } // ==> end first method


        /// <summary>
        /// THis is your first program
        /// this is also called a method and for now it is only calculating  24 x 17
        /// Then it will display the solution
        /// </summary>
        public static void FirstProgram() 
        {
            int MathSolution = 24 * 17;

            Console.WriteLine("Math solution : " + MathSolution);
        }
    }
}
