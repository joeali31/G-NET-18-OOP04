using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[10];
        private int count = 0;
        public void OpenCinema()
        {
            Console.WriteLine("Cinema is open ");
        }

        public void CloseCinema()
        {
            Console.WriteLine("Cinema is closed ");
        }

        public void AddTicket(Ticket t)
        {
            if (count < tickets.Length)
            {
                tickets[count++] = t;
            }
        }

        public int GetTotalTicket()
        {
            return count;
        }

        public void PrintAllTickets()
        {
            foreach (Ticket t in tickets)
            {
                if (t != null)
                {
                    t.PrintTicket();
                    Console.WriteLine();
                }

            }
        }

        public static void ProcessTicket(Ticket t)
        {
            t.PrintTicket();
        }
    }
}
