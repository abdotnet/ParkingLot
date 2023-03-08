using ParkingLot.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Infrastructure.Services
{
    public class Vehicle : IVehicle
    {
        public string License { get; set; }
        public string VehicleType { get; set; }

        /// <summary>
        /// Get vehicle type
        /// </summary>
        /// <returns></returns>
        public string GetVehicleType()
        {
            return VehicleType;
        }
    }
}
