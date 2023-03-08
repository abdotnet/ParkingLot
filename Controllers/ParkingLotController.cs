using Microsoft.AspNetCore.Mvc;
using ParkingLot.Infrastructure.Interfaces;
using ParkingLot.Infrastructure.Models;
using ParkingLot.Infrastructure.Services;
using System.Net;

namespace ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ParkingLotController : ControllerBase
    {
        private readonly ILogger<ParkingLotController> _logger;
        private IParkingLot _parkingLot;

        public ParkingLotController(ILogger<ParkingLotController> logger, IParkingLot parkingLot)
        {
            _logger = logger;
            _parkingLot = parkingLot;
        }

        [HttpGet(Name = "AddVehicle")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddVehicle(Vehicle vehicle)
        {
            var response = await _parkingLot.AddVehicle(vehicle);
            _logger.LogInformation(response);
            return Ok(response);
        }
    }
}
