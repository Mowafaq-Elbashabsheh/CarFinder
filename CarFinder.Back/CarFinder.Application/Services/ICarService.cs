using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Domain.Models;

namespace CarFinder.Application.Services
{
    public interface ICarService
    {
        public Task<CarMake> GetAllMakes();
        public Task<VehicleType> GetVehicleTypesForMakeById();
        public Task<CarModel> GetModelsForMakeId();
    }
}
