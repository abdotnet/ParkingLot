using ParkingLot.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Infrastructure.Services
{
    public class ParkingLots : IParkingLot
    {
        public long Capacity { get; set; }
        public long AvailableSpace { get; set; }
        public List<ParkingSpace> ParkingSpaces { get; set; } = new();

        public async Task<string> AddVehicle(Vehicle vehicle)
        {
            if (ParkingSpaces.Count <= Capacity)
            {
                ParkingSpaces.Add(new ParkingSpace()
                {
                    Vehicle = vehicle,
                    SpaceNumber = AvailableSpace
                });
                return await Task.FromResult(vehicle.License);
            }
            return string.Empty;
        }

        public async Task<string> RemoveVehicle(Vehicle vehicle)
        {

            var parkingSpace = ParkingSpaces.Where(c => c.Vehicle == vehicle).FirstOrDefault();

            if (parkingSpace != null)
            {
                ParkingSpaces.Remove(parkingSpace);
                return await Task.FromResult(parkingSpace.Vehicle.License);
            }
            return string.Empty;
        }

        public long GetAvailableSpaces()
        {
            AvailableSpace = Capacity - ParkingSpaces.Count;
            return AvailableSpace;
        }
    }
}
