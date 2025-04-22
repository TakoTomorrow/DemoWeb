using DemoWeb.DataAcesses;
using DemoWeb.DataAcesses.Interface;
using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;
using DemoWeb.Services.Interface;

namespace DemoWeb.Services
{
    internal class HouseService : IHouseService
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

        public async Task<HouseDTO> GetAsync(int id)
        {
            var house = await _houseDA.GetAsync(id);

            if (house == null)
                return null!;

            return this.Convert(house);
        }

        public async Task ModifyAsync(HouseDTO dto)
        {
            var oldHouse = await _houseDA.GetAsync(dto.Id);

            if (oldHouse == null)
                return;

            var newHouse = this.Convert(dto);

            await _houseDA.ModifyAsync(newHouse);
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

        /// <summary>
        /// 轉換 DB Table 為 DTO
        /// </summary>
        /// <param name="house"></param>
        /// <returns></returns>
        private HouseDTO Convert(House house)
        {
            return new HouseDTO
            {
                Id = house.Id,
                Address = house.Address,
                NumberOfRooms = house.NumberOfRooms,
                NumberOfUnits = house.NumberOfUnits,
                Price = house.Price
            };
        }          
    }  
}
