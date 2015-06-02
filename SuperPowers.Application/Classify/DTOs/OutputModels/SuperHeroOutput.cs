using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify.DTOs.OutputModels
{
    public class SuperHeroOutput : EntityDto, IOutputDto
    {
        public string Name { get; set; }
    }
}
