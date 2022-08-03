using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;



namespace Asptasks.Models
{
    [Table(name:"Categories")]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        public string CategoryName { get; set; }

        //[Required]
        //[Column(TypeName ="varchar(100)")]
        //[Display(Name = "Category Description")]
        //public string CategoryDescription { get; set; }

        //[Required]
        //public string CategoryPin { get; set; }

        #region Navigation Properties to the Book Model

        public ICollection<Product> Products { get; set; }

        #endregion
    }
}
