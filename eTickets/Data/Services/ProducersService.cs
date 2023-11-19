using eTickets.Data.Base;
using System;
using System.Collections.Generic;

namespace eTickets.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
