using System;
using System.Collections.Generic;
using System.Text;
using PiwoBack.Data.Models;

namespace PiwoBack.Services.Interfaces
{
    public interface IBeerService
    {
        IEnumerable<Beer> GetAll();
        Beer GetBeer(int id);
    }
}
