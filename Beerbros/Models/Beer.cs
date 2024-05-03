using System.ComponentModel.DataAnnotations.Schema;

namespace Beerbros.Web.Models
{
    [Table("beers")]
    public class Beer
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public Single Abv {  get; set; }

        public Single Ibu {  get; set; }

        public Single Srm {  get; set; }

        public Int32 Upc {  get; set; }

        public String FilePath {  get; set; }

        [Column("descript")]
        public String Description {  get; set; }

        [Column("add_user")]
        public Int32 AddUser {  get; set; }

        [Column("last_mod")]
        public DateTime ModifiedAt { get; set; }

        [Column("brewery_id")]
        public Int32 BreweryId { get; set; }

        [Column("cat_id")]
        public Int32 CategoryId { get; set; }

        [Column("style_id")]
        public String StyleId { get; set; }

        public Category Category { get; set; }

        public Brewery Brewery { get; set; }

        [ForeignKey("BeerId")]
        public ICollection<Rating> Ratings { get; set; }
    }
}
