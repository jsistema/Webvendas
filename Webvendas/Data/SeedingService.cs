using System.Linq;
using Webvendas.Models;
using Webvendas.Models.Enums;

namespace Webvendas.Data
{
    public class SeedingService
    {
        private WebvendasContext _context;

        public SeedingService(WebvendasContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            //Pesquisar nesta questão, como percorrer todo o BD sem a necessidade de tabela a tabela.
            if (
                _context.Department.Any()  ||
                _context.SalesRecords.Any() ||
                _context.Sellers.Any()
            )
            {
                return;
            }

            // Popula tabela de Deparamentos
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob@bog.com", new System.DateTime(1998, 4, 21), 1000, d1);
            Seller s2 = new Seller(2, "Mac", "mac@bog.com", new System.DateTime(1998, 4, 21), 2000, d2);
            Seller s3 = new Seller(3, "Tob", "top@bog.com", new System.DateTime(1998, 4, 21), 2500, d3);
            Seller s4 = new Seller(4, "Luc", "luc@bog.com", new System.DateTime(1998, 4, 21), 1800, d4);
            Seller s5 = new Seller(5, "Joe", "joe@bog.com", new System.DateTime(1998, 4, 21), 1400, d1);


            SalesRecord sr1 = new SalesRecord(1, new System.DateTime(), 11000, SaleStatus.Build, s1);
            SalesRecord sr2 = new SalesRecord(2, new System.DateTime(), 2000, SaleStatus.Build, s2);
            SalesRecord sr3 = new SalesRecord(3, new System.DateTime(), 1000, SaleStatus.Build, s3);
            SalesRecord sr4 = new SalesRecord(4, new System.DateTime(), 800, SaleStatus.Build, s4);
            SalesRecord sr5 = new SalesRecord(5, new System.DateTime(), 350, SaleStatus.Build, s5);
            SalesRecord sr6 = new SalesRecord(6, new System.DateTime(), 100, SaleStatus.Build, s4);


            //Populando tabelas

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Sellers.AddRange(s1, s2, s3, s5, s5);

            _context.SalesRecords.AddRange(sr1, sr2, sr3, sr4, sr5);

            _context.SaveChanges();


        }

    }
}
