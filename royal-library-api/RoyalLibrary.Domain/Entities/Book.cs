using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Domain.Entities
{
    public class Book
    {
        [Key]
        [Column("book_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("total_copies")]
        [DefaultValue(0)]
        public int TotalCopies { get; set; }

        [Required]
        [Column("copies_in_use")]
        [DefaultValue(0)]
        public int CopiesInUse { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(80)]
        public string Isbn { get; set; }

        [StringLength(50)]
        public string Category { get; set; }


    }
}
