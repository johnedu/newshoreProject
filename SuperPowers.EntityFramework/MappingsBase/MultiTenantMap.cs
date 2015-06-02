﻿using SuperPowers.BaseEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.MappingsBase
{
    public class MultiTenantMap<TMultiTenantEntidad> : EntityTypeConfiguration<TMultiTenantEntidad>
        where TMultiTenantEntidad : class, IMultiTenant
    {
        public MultiTenantMap()
            : base()
        {
            //Llave Primaria
            HasKey(mt => mt.Id);

            //Propiedad de TenantId
            Property(mt => mt.TenantId).IsRequired();
        }

    }
}
