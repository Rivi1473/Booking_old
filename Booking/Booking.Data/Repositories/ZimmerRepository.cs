using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data.Repositories
{
    public class ZimmerRepository:IZimmerRepository
    {
        private readonly DataContext _context;
        public ZimmerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Zimmer> GetAllZimmers()
        {
            return _context.ZimmersList;
        }
        public Zimmer GetZimmerById(int id)
        {
            return _context.ZimmersList.Find(o => o.codeZimmer == id);
        }
        public void AddZimmer(Zimmer z)
        {
            _context.ZimmersList.Add(new Zimmer
            {
                codeZimmer = _context.CntZimmers++,
                name = z.name,
                address = z.address,
                city = z.city,
                description = z.description,
                price = z.price
            });
        }
        public void UpdateZimmer(int i,Zimmer z)
        {
            var zimmer = _context.ZimmersList.Find(e => e.codeZimmer == i);
            zimmer.name = z.name;
            zimmer.price = z.price;
            zimmer.address = z.address;
            zimmer.city = z.city;
            zimmer.description = z.description;
        }
        public void DeleteZimmer(int id)
        {
            var zimmer = _context.ZimmersList.Find(o => o.codeZimmer == id);
            _context.ZimmersList.Remove(zimmer);
        }
    }
}
