using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webvendas.Models.Enums;

namespace Webvendas.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public double Amouth { get; set; }

        public SaleStatus Status { get; set; }

        public Seller  Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amouth, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amouth = amouth;
            Status = status;
            Seller = seller;
        }
    }
}
