using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Application.Services;
using CarFinder.Domain.Models;

namespace CarFinder.Infrastructure.Services
{
    public class CarService : ICarService
    {
        public Task<CarMake> GetAllMakes()
        {
            throw new NotImplementedException();
        }

        public Task<CarModel> GetModelsForMakeId()
        {
            throw new NotImplementedException();
        }

        public Task<VehicleType> GetVehicleTypesForMakeById()
        {
            throw new NotImplementedException();
        }
    }
}
