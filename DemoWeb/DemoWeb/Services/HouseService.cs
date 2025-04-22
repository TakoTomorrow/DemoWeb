using DemoWeb.DataAcesses;
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
            var house = this.Convert(dto);
            house.CreatedDate = DateTime.Now;
            house.UpdateDate = DateTime.Now;            

            await _houseDA.CreateAsync(house);    
        }

        /// <summary>
        /// 轉換 DTO 為 DB Table
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        private House Convert(HouseDTO dto)
        {
            return new House
            {
                Id = dto.Id,
                Address = dto.Address,
                NumberOfRooms = dto.NumberOfRooms,
                NumberOfUnits = dto.NumberOfUnits,
                Price = dto.Price
            };
        }        
    }  
}
