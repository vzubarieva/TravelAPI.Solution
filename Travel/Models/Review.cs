using System.Collections.Generic;

namespace Travel.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
