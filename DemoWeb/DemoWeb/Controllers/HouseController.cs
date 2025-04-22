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

        // GET api/<HouseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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

        // PUT api/<HouseController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
