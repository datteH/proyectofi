﻿using Proyecto.ETPS4.Grupo13.Entities.Common;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Service.Contracts
{
    public interface ISaleDetailService
    {
        Task<IEnumerable<SaleDetail>>? GetByHeaderId(SaleDetailRequestParameters parameters, bool trackChanges);
        Task CreateItem(SaleDetail item);
    }
}
