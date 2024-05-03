using System.ComponentModel.DataAnnotations.Schema;

namespace Beerbros.Web.Models
{
    [Table("styles")]
    public class Style
    {
        public Int32 Id {  get; set; }

        public Int32 CategoryId {  get; set; }

        public String Name { get; set; }

        [Column("last_mod")]
        public DateTime ModifiedAt { get; set; }

        public virtual Category Category { get; set; }
    }
}
