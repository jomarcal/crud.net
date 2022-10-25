using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspCore_Crud.Models
{
    [Table("Product")]
    public class Product
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        public string? Name {get; set; }

    }
}
