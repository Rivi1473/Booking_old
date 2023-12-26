using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Repositories
{
    public interface IRenterRepository
    {
        public List<Renter> GetAllRenters();
        public Renter GetRenterById(int id);
        public void AddRenter(Renter r);
        public void UpdateRenter(int id,Renter r);
        public void DeleteRenter(int id);
    }
}
