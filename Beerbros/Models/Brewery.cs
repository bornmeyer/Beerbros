using System.ComponentModel.DataAnnotations.Schema;

namespace Beerbros.Web.Models
{
    [Table("breweries")]

    public class Brewery
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        [Column("address1")]
        public String FirstAddress {  get; set; }

        [Column("address2")]
        public String SecondAddress {  get; set; }

        public String City {  get; set; }

        public String State {  get; set; }

        [Column("code")]
        public String PostalCode { get; set; }

        public String Country { get; set; } 

        public String Phone { get; set; }

        public String WebSite {  get; set; }

        public String FilePath {  get; set; }

        [Column("descript")]
        public String Description { get; set; }

        public Int32 AddUser { get; set; }

        [Column("last_mod")]
        public DateTime ModifiedAt { get; set; }

        public ICollection<Beer> Beers { get; set; }
    }
}
