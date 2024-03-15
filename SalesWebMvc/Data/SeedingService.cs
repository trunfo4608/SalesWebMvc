using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public void Seed()
        {
            if(_context.Departament.Any() || 
                _context.Sellers.Any() ||
                _context.SalesRecords.Any())
            {
                return;
            }

            Departament d1 = new Departament("Computers");
            Departament d2 = new Departament("Eletronics");
            Departament d3 = new Departament("Fashion");
            Departament d4 = new Departament("Books");

            Seller s1 = new Seller("Renato Alves","ralves@gmail.com",new DateTime(1981,5,7),3550.0,d1);
            Seller s2 = new Seller("Manoel Silva", "manoel@gmail.com", new DateTime(1956, 1, 6), 3000.0, d1);
            Seller s3 = new Seller("Camla Alves", "camila@gmail.com", new DateTime(1984, 8, 28), 4000.0, d2);
            Seller s4 = new Seller("Celia Pereira", "celia@gmail.com", new DateTime(1957, 12, 12), 4100.0, d3);
            Seller s5 = new Seller("Jose Vasconcelos", "jose@gmail.com", new DateTime(1955, 7, 14), 3100.0, d4);


            SalesRecord sr1 = new SalesRecord( new DateTime(2019, 9, 1), 11000.0, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord( new DateTime(2019, 9, 2), 3200.0, SalesStatus.Billed, s1);
            SalesRecord sr3 = new SalesRecord(new DateTime(2019, 8, 10), 250.0, SalesStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(new DateTime(2019, 8, 11), 950.0, SalesStatus.Pending, s2);
            SalesRecord sr5 = new SalesRecord(new DateTime(2019, 8, 12), 750.0, SalesStatus.Billed, s3);
            SalesRecord sr6 = new SalesRecord( new DateTime(2019, 8, 13), 2450.0, SalesStatus.Canceled,s4);
            SalesRecord sr7 = new SalesRecord( new DateTime(2019, 7, 17), 3450.0, SalesStatus.Billed, s5);

            _context.Departament.AddRange(d1,d2,d3,d4);

            _context.Sellers.AddRange(s1,s2,s3, s4, s5);

            _context.SalesRecords.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7);

            _context.SaveChanges();
        }
    }
}
