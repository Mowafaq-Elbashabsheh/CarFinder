using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Domain.DTOs;
using CarFinder.Domain.Models;

namespace CarFinder.Application.Services
{
    public interface ICarService
    {
        public Task<GetMakesResp> GetAllMakes();
        public Task<GetVehicleTypeResp> GetVehicleTypesForMakeById(int id);
        public Task<GetModelsResp> GetModelsForMakeId(int id, int year);
    }
}
