using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPowers.BaseEntity
{
    public interface IMultiTenant : IEntity
    {
        int TenantId { get; set; }
    }
}