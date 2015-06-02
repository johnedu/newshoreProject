using SuperPowers.Classify.DTOs.OutputModels;
using SuperPowers.Classify.Entities;
using SuperPowers.Utilities.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify
{
    public class AutoMapperClassifyProfile : AutoMapperBaseProfile
    {
        public AutoMapperClassifyProfile()
            : base("AutoMapperClassifyProfile")
        {

        }

        protected override void CrearMappings()
        {
            CreateMap<SuperPowersPerson, SuperHeroOutput>();
        }
    }
}
