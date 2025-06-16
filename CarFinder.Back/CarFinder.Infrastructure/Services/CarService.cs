using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CarFinder.Application.Services;
using CarFinder.Domain.DTOs;
using CarFinder.Domain.Models;

namespace CarFinder.Infrastructure.Services
{
    public class CarService : ICarService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public CarService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<GetMakesResp> GetAllMakes()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var url = "https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                GetMakesResp makes = JsonSerializer.Deserialize<GetMakesResp>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return makes;
            }
            return new GetMakesResp { Count = 0, Message = response.StatusCode.ToString(), Results = null, SearchCriteria = "" };
        }

        public async Task<GetVehicleTypeResp> GetVehicleTypesForMakeById(int id)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var url = $"https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/{id}?format=json";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                GetVehicleTypeResp vehicles = JsonSerializer.Deserialize<GetVehicleTypeResp>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return vehicles;
            }
            return new GetVehicleTypeResp { Count = 0, Message = response.StatusCode.ToString(), Results = null, SearchCriteria = $"Make ID: {id}" };
        }

        public async Task<GetModelsResp> GetModelsForMakeId(int id, int year)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var url = $"https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/{id}/modelyear/{year}?format=json";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                GetModelsResp models = JsonSerializer.Deserialize<GetModelsResp>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return models;
            }
            return new GetModelsResp { Count = 0, Message = response.StatusCode.ToString(), Results = null, SearchCriteria = $"Make ID: {id} | ModelYear:{year}" };
        }
    }
}
