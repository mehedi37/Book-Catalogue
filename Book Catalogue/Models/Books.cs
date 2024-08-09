using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Book_Catalogue.Models
{
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? BookId { get; set; }
        public required string Cover { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        [AllowNull]
        public string Description { get; set; } = String.Empty;
        public required string ISBN { get; set; }
        public required string Publisher { get; set; }
        public required DateOnly PublishDate { get; set; }
    }
}
