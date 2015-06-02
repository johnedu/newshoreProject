using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.BaseEntity
{
    public abstract class EntityMultiTenant : Entity, IMultiTenant, IMustHaveTenant
    {
        public int TenantId { get; set; }
    }

}