using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify.DTOs.OutputModels
{
    public class GetClassifyHeroesAndVillainsOutput : IOutputDto
    {
        public List<SuperHeroOutput> ListHeroes { get; set; }
        public List<SuperHeroOutput> ListVillains { get; set; }
    }
}
