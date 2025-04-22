using System.ComponentModel.DataAnnotations;

namespace DemoWeb.DataBaseContext.DbModels
{
    public class House
    {
        /// <summary>
        /// House ID
        /// </summary>\
        [Key]
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

        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpdateDate { get; set; }

    }
}
