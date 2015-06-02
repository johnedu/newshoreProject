using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify.DTOs.InputModels
{
    public class GetClassifyHeroesAndVillainsInput : IInputDto
    {
        public List<string> ListHeroesAndVillains { get; set; }
    }
}
