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

        /// <summary>
        /// 取得房屋資料 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<House> GetAsync(int id);

        /// <summary>
        /// 更新房屋資料
        /// </summary>
        /// <param name="house"></param>
        /// <returns></returns>
        public Task ModifyAsync(House house);
    }
}
