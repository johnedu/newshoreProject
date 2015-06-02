using SuperPowers.Classify.Entities;
using SuperPowers.MappingsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.Classify.Mappings
{
    public class SuperPowersPersonMap : MultiTenantMap<SuperPowersPerson>
    {
        public SuperPowersPersonMap()
        {
            //Atributos
            Property(superPowersPerson => superPowersPerson.Name).IsRequired();
            Property(superPowersPerson => superPowersPerson.Type).IsRequired();

            //Tabla
            ToTable("super_powers_person");
        }
    }
}
