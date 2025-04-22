using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

    /// <summary>
    /// House 資料表配置
    /// </summary>
    public static class HouseTableConfig
    {
        public static void Configure(this EntityTypeBuilder<House> builder)
        {
            builder.ToTable("Houses")
                .HasKey(h => h.Id);

            builder.Property(h => h.Id)
                .ValueGeneratedOnAdd();

            builder.Property(h => h.Address)
                .IsRequired()
                .HasMaxLength(200)
                .HasComment("地址");

            builder.Property(h => h.NumberOfRooms)
                .HasComment("房間數量");

            builder.Property(h => h.NumberOfUnits)
                .HasComment("坪數");

            builder.Property(h => h.Price)
                .HasComment("房屋售價");
        }
    }
}
