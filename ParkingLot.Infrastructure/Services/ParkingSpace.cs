using ParkingLot.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Infrastructure.Services
{
    public class ParkingSpace : IParkingSpace
    {
        public long SpaceNumber { get; set; }
        public Vehicle Vehicle { get; set; }

        /// <summary>
        ///  Is Available
        /// </summary>
        /// <returns></returns>
        public async Task<bool> IsAvailable(ParkingSpace space)
        {
            return await Task.FromResult(space == null);
        }
    }
}
