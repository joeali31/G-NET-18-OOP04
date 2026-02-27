using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(bool is3D, string movieName, decimal price) : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"TicketId: #{TicketId} | MovieName: {MovieName} | Price: {Price} | PriceAfterTax: {PriceAfterTax} | Is3D: {Is3D}");
        }
    }
}
