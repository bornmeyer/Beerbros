using System.ComponentModel.DataAnnotations.Schema;

namespace Beerbros.Web.Models
{
    public class Category
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        [Column("last_mod")]
        public DateTime ModifiedAt { get; set; }

        public ICollection<Beer> Beers { get; set; }

    }
}
