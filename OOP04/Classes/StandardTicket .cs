using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    internal class StandardTicket : Ticket
    {
        public string? SeatNumber { get; set; }
        public StandardTicket(string seatNumber , string movieName , decimal price) : base(movieName , price)
        {
            SeatNumber = seatNumber;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"TicketId: #{TicketId} | MovieName: {MovieName} | Price: {Price} | PriceAfterTax: {PriceAfterTax} | SeatNumber: {SeatNumber}");
        }
    }
}
