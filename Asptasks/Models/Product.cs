using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Asptasks.Models
{
    [Table(name:"Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [DefaultValue(1)]
        public int Productcopies { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsEnabled { get; set; }

        #region Navigation Properties to the Category Model

        virtual public int CategoryId { get; set; }

        [ForeignKey(nameof(Product.CategoryId))]
        public Category Category { get; set; }

        #endregion
    }
}
