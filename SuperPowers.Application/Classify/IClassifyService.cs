using Abp.Application.Services;
using SuperPowers.Classify.DTOs.InputModels;
using SuperPowers.Classify.DTOs.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify
{
    public interface IClassifyService : IApplicationService
    {
        GetClassifyHeroesAndVillainsOutput GetClassifyHeroesAndVillains(GetClassifyHeroesAndVillainsInput listSuperPowersPersons);

        GetAllSuperHeroesOutput GetAllSuperHeroes();
    }
}
