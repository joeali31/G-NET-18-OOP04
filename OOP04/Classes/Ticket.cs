using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    public class Ticket
    {
        private static int Counter = 0;
        public string? MovieName { get; set; }
        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int TicketId { get; }
        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName , decimal price)
        { 
            MovieName = movieName;
            Price = price;
            Counter++;
            TicketId = Counter;
        }

        public void SetPrice(decimal value)
        {
            Price = value;
        }
        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }
        public virtual void PrintTicket()
        {
            Console.WriteLine($"TicketId: #{TicketId} | MovieName: {MovieName} | Price: {Price} | PriceAfterTax: {PriceAfterTax}");
        }

    }
}
