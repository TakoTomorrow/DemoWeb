using DemoWeb.DataAcesses.Interface;
using DemoWeb.DataBaseContext;
using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;

namespace DemoWeb.DataAcesses
{
    internal class HouseDA: IHouseDA
    {
        private readonly DemoDbContext _context;

        public HouseDA(DemoDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(House house)
        {                       
        }
    }
}
