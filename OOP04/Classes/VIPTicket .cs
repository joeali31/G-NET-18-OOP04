using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    internal class VIPTicket : Ticket
    {
        public bool _LoungeAccess { get; set; }
        public VIPTicket(bool loungaccess , string movieName, decimal price) : base(movieName, price)
        {
            _LoungeAccess = loungaccess ;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"TicketId: #{TicketId} | MovieName: {MovieName} | Price: {Price} | PriceAfterTax: {PriceAfterTax} | LoungeAccess: {_LoungeAccess}");
        }
    }
}
