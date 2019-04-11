using System.Collections.Generic;

namespace RentApp.Infrastructure
{
    public class Owner : Person
    {
        public List<Flat> Flats { get; set; }
    }
}