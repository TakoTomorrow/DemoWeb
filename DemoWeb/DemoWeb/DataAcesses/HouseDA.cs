using DemoWeb.DataAcesses.Interface;
using DemoWeb.DataBaseContext;
using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;
using Microsoft.EntityFrameworkCore;

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
            await _context.Houses.AddAsync(house);
            await _context.SaveChangesAsync();
        }

        public async Task<House> GetAsync(int id)
        {
            return (await _context.Houses
                .Where(h => h.Id == id)            
                .FirstOrDefaultAsync())!;
        }
    }
}
