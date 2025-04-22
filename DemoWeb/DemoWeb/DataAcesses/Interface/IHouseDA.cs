using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;

namespace DemoWeb.DataAcesses.Interface
{
    public interface IHouseDA
    {
        /// <summary>
        /// 新增房屋資料
        /// </summary>
        /// <param name="house"></param>
        /// <returns></returns>
        public Task CreateAsync(House house);
    }
}
