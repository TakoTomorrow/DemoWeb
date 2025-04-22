using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;

namespace DemoWeb.Services.Interface
{
    public interface IHouseService
    {
        /// <summary>
        /// 新增房屋資料
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public Task CreateAsync(HouseDTO dto);
    }
}
