using PiwoBack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiwoBack.Services.Interfaces
{
    public interface IBrewingGroupService
    {
        IEnumerable<BrewingGroup> GetAll();
        BrewingGroup GetBrewingGroup(int id);
    }
}
