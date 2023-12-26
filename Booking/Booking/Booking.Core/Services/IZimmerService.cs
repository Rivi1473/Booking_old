using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Services
{
    public interface IZimmerService
    {
        public List<Zimmer> GetAllZimmers();
        public Zimmer GetZimmerById(int id);
        public void AddZimmer(Zimmer z);
        public void UpdateZimmer(int id, Zimmer z);
        public void DeleteZimmer(int id);

    }
}
