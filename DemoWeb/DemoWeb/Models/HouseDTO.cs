namespace DemoWeb.Models
{
    public class HouseDTO
    {
        /// <summary>
        /// House ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// 房間數量
        /// </summary>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// 坪數
        /// </summary>
        public int NumberOfUnits { get; set; }

        /// <summary>
        /// 房屋售價
        /// </summary>
        public int Price { get; set; }
    }
}
