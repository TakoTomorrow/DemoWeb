using DemoWeb.DataAcesses.Interface;
using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;
using DemoWeb.Services.Interface;

namespace DemoWeb.Services
{
    internal class HouseService: IHouseService
    {
        private readonly IHouseDA _houseDA;

        public HouseService(IHouseDA houseDA)
        {
            _houseDA = houseDA;
        }

        public async Task CreateAsync(HouseDTO dto)
        {            
        }
    }  
}
