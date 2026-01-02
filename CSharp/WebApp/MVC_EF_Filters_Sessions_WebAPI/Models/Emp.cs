using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_EF_Filters_Sessions_WebAPI.Models
{
    [Table("Employee")]
    public class Emp
    {
        [Key]
        [Column("Id",TypeName ="int")]
        public int Id { get; set; }

        [Column("Name",TypeName ="varchar(20)")]
        public string Name { get; set; }

        [Column("Address",TypeName ="varchar(20)")]
        public string Address { get; set; }

    }
}
