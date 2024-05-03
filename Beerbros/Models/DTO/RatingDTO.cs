using System.ComponentModel.DataAnnotations.Schema;

namespace Beerbros.Web.Models.DTO
{
    public class RatingDTO
    {
       
        public String Name { get; set; }

        public Int32 BeerId { get; set; }

        public Int32 Score { get; set; }

        public String Location { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime SyncedAt { get; set; }

        public String Comment { get; set; }

        public String Container { get; set; }

        public String Temperature { get; set; }

        public String Weather { get; set; }

        public Int32 HopRating { get; set; }

        public Int32 MaltRating { get; set; }

        public String Country { get; set; }

        public String City { get; set; }

        public Double Longitude { get; set; }

        public Double Latitude { get; set; }
    }
}
