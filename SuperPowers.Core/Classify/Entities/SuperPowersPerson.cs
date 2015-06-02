using SuperPowers.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify.Entities
{
    public class SuperPowersPerson : EntityMultiTenant
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}