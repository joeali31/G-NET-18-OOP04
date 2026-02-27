using OOP04.Classes;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            /* Q1 
             * Static Binding : The method call is decided at compile time (before the program runs)
             * Dynamic Binding : The method call is decided at runtime (while the program is running
             */

            /* Q2 
             * Method Overloading : Method overloading means having multiple methods with the same name in the same class, but with different parameters (number or type)
             * Method Overriding : Method overriding means a child class provides its own version of a method defined in the parent class
             */

            /* Q3 
             * virtual : This method CAN be overridden by child classes.
             */
            #endregion


            #region Part 02
            //Ticket t1 = new StandardTicket("A-5" , "inception" , 500);
            //Ticket t2 = new VIPTicket(true , "interstaller" , 300);
            //Ticket t3 = new IMAXTicket(false , "Dune" , 200);

            //Cinema c1 = new Cinema();
            //c1.AddTicket(t1);
            //c1.AddTicket(t2);
            //c1.AddTicket(t3);

            //c1.OpenCinema();

            //Console.WriteLine();

            //c1.PrintAllTickets();

            //c1.CloseCinema();
            #endregion

        }
    }
}
