using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaApi.Models
{
    public class VillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { get; set; }
        [ForeignKey("villa")]
        public int VillaId { get; set; }
        public Villa villa { get; set; }
        public string SpecialDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
