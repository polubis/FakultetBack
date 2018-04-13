using PiwoBack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiwoBack.Services.Interfaces
{
    public interface IBreweryService
    {
        IEnumerable<Brewery> GetAll();
        Brewery GetBrewery(int id);
    }
}
