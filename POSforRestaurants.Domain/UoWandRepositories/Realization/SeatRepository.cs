using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforRestaurants.Domain.Data.Entities;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using System.Data.Entity;

namespace POSforRestaurants.Domain.UoWandRepositories.Realization
{
    public class SeatRepository:GenericRepository<Seat>, ISeatRepository
    {
        public SeatRepository(DbContext context)
           : base(context)
        { }

        public async Task<Seat> GetByIdAsync(int id)
        {
            return await _dbset.Include(x=>x.Orders).Where(x => x.SeatId == id).FirstOrDefaultAsync();
        }
    }
}
