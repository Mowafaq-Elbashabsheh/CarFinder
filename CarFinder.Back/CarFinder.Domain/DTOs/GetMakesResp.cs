using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Domain.Models;

namespace CarFinder.Domain.DTOs
{
    public class GetMakesResp
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public List<CarMake> Results { get; set; }
    }
}
