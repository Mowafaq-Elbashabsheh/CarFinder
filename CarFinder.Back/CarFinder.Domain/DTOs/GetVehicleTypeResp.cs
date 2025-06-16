using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Domain.Models;

namespace CarFinder.Domain.DTOs
{
    public class GetVehicleTypeResp
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public List<VehicleType> Results { get; set; }
    }
}
