using DemoWeb.DataBaseContext.DbModels;
using DemoWeb.Models;
using DemoWeb.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        /// <summary>
        /// 取得房屋資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<Response<HouseDTO>> GetAsync(int id)
        {
            try
            {
                var house = await _houseService.GetAsync(id);

                if (house == null)
                {
                    return new Response<HouseDTO>(null!, ResponseCode.Error, "查無資料");
                }

                return new Response<HouseDTO>(house, ResponseCode.Success);
            }
            catch (Exception ex)
            {
                return new Response<HouseDTO>(null!, ResponseCode.Error, ex.Message);
            }
        }

        /// <summary>
        /// 新增房屋資料
        /// </summary>
        /// <param name="house"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Response> CreateAsync([FromBody] HouseDTO house)
        {
            try
            {
                await _houseService.CreateAsync(house);

                return new Models.Response(ResponseCode.Success);
            }
            catch (Exception ex)
            {
                return new Models.Response(ResponseCode.Error, ex.Message);
            }            
        }

        /// <summary>
        /// 更新房屋資料
        /// </summary>
        /// <param name="house"></param>
        [HttpPut]
        public async Task<Response> ModifyAsync([FromBody] HouseDTO house)
        {
            try
            {
                await _houseService.ModifyAsync(house);

                return new Models.Response(ResponseCode.Success);
            }
            catch (Exception ex)
            {
                return new Models.Response(ResponseCode.Error, ex.Message);
            }      
        }

        /// <summary>
        /// 刪除房屋資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<Response> DeleteAsync(int id)
        {
            try
            {
                await _houseService.DeleteAsync(id);

                return new Models.Response(ResponseCode.Success);
            }
            catch (Exception ex)
            {
                return new Models.Response(ResponseCode.Error, ex.Message);
            }      
        }
    }
}
