namespace Migrations.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Tag
    {
        // [Key]
        // [StringLength(20)]
        // public string TagId { set; get; }

        [Key]
        [StringLength(20)]
        public int TagId { set; get; }

        [Column(TypeName = "ntext")]
        public string Content { set; get; }
    }
}