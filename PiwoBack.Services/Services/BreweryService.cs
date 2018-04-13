using PiwoBack.Data.Models;
using PiwoBack.Repository.Interfaces;
using PiwoBack.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiwoBack.Services.Services
{
    public class BreweryService:IBreweryService
    {
        private readonly IRepository<Brewery> _breweryRepository;

        public BreweryService(IRepository<Brewery> breweryRepository)
        {
            _breweryRepository = breweryRepository;
        }

        public IEnumerable<Brewery> GetAll()
        {
            var breweries = _breweryRepository.GetAll();
            return breweries;
        }

        public Brewery GetBrewery(int id)
        {
            var brewery = _breweryRepository.GetBy(x => x.Id == id);

            if (brewery == null)
            {
                return null;
            }

            return brewery;
        }
    }
}
