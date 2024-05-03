using System.ComponentModel.DataAnnotations.Schema;

namespace Beerbros.Web.Models
{
    public class Beer
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public Single Abv {  get; set; }

        public Single Ibu {  get; set; }

        public Single Srm {  get; set; }

        public Single Upc {  get; set; }

        public String FilePath {  get; set; }

        [Column("descript")]
        public String Description {  get; set; }

        public Int32 AddUser {  get; set; }

        [Column("last_mod")]
        public DateTime ModifiedAt { get; set; }

        public Int32 BreweryId { get; set; }

        public Int32 CategoryId { get; set; }

        public Int32 StyleId { get; set; }


        public Category Category { get; set; }

        public Style Style { get; set; }

        public Brewery Brewery { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
