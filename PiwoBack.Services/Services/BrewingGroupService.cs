using PiwoBack.Data.Models;
using PiwoBack.Repository.Interfaces;
using PiwoBack.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiwoBack.Services.Services
{
    public class BrewingGroupService:IBrewingGroupService
    {
        private readonly IRepository<BrewingGroup> _brewingGroupRepository;
           
        public BrewingGroupService(IRepository<BrewingGroup> brewingGroupRepository)
        {
            _brewingGroupRepository = brewingGroupRepository;
        }

        public IEnumerable<BrewingGroup> GetAll()
        {
            var brewingGroups = _brewingGroupRepository.GetAll();
            return brewingGroups;
        }

        public BrewingGroup GetBrewingGroup(int id)
        {
            var brewingGroup = _brewingGroupRepository.GetBy(x => x.Id == id);
            _brewingGroupRepository.GetRelatedCollections(brewingGroup, x => x.Breweries);
            return brewingGroup;
        }
    }
}
