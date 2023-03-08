using ParkingLot.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Infrastructure.Interfaces
{
    public interface IParkingLot
    {
        Task<string> AddVehicle(Vehicle vehicle);
        Task<string> RemoveVehicle(Vehicle vehicle);
        long GetAvailableSpaces();
    }
}
