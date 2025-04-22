using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;

namespace DemoWeb.DataAcesses.Interface
{
    public interface IHouseDA
    {
        public Task CreateAsync(House house);
    }
}
