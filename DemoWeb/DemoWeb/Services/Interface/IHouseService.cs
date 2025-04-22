using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;

namespace DemoWeb.Services.Interface
{
    public interface IHouseService
    {
        public Task CreateAsync(HouseDTO dto);
    }
}
