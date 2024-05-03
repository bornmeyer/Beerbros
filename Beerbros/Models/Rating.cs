using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Beerbros.Web.Models
{
    public class Rating
    {
        [Column("ID")]
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public String BeerId {  get; set; }

        [Column("Bewertung")]
        public Int32 Score {  get; set; }

        [Column("Ort")]
        public String Location {  get; set; }

        [Column("Zeit")]
        public DateTime CreatedAt { get; set; }

        [Column("sync")]
        public DateTime SyncedAt { get; set;}

        [Column("Kommentar")]
        public String Comment {  get; set; }

        [Column("Bild")]
        public Byte[] Picture { get; set; }

        [Column("Temp")]
        public String Temperature{ get; set; }

        [Column("Wetter")]
        public String Weather { get; set; }

        [Column("Hopfen")]
        public Int32 HopRating {  get; set; }

        [Column("Malz")]
        public Int32 MaltRating {  get; set; }

        [Column("Land")]
        public String Country {  get; set; }

        [Column("Stadt")]
        public String City {  get; set; }

        [Column("Bild_URL")]
        public String PictureUrl {  get; set; }

        [Column("lon")]
        public Double Longitude {  get; set; }

        [Column("lat")]
        public Double Latitude { get; set; }

        public Beer Beer { get; set; }
    }
}
