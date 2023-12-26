using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service
{
    public class ZimmerService:IZimmerService
    {
        private readonly IZimmerRepository _zimmerRepository;
        public ZimmerService(IZimmerRepository zimmerRepository)
        {
            _zimmerRepository = zimmerRepository;
        }
        public List<Zimmer> GetAllZimmers()
        {
            return _zimmerRepository.GetAllZimmers();
        }
        public Zimmer GetZimmerById(int id)
        {
            return _zimmerRepository.GetZimmerById(id);
        }
        public void AddZimmer(Zimmer zimmer)
        {
            _zimmerRepository.AddZimmer(zimmer);
        }
        public void UpdateZimmer(int i, Zimmer zimmer)
        {
            _zimmerRepository.UpdateZimmer(i,zimmer);
        }
        public void DeleteZimmer(int id)
        {
            _zimmerRepository.DeleteZimmer(id);
        }
    }
}
