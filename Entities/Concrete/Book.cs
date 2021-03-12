using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int BookId { get; set; }
        public int CategoryId{ get; set; }
        public string BookName{ get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice{ get; set; }
        public int NumberOfPage { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}
