using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace LMS.WEB.Models
{
    [Table(name:"Author")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AuthorId { get; set; }


        [Required]
        public string AuthorName { get; set; }


        #region Navigation Properties to the Book Model

        [Required]
        public int BookId { get; set; }

        [ForeignKey(nameof(Author.BookId))]
        public Book Book { get; set; }

        #endregion
    }
}
