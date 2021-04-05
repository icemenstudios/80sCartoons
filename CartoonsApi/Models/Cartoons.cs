using System;
namespace CartoonsApi.Models
{
    public class Cartoons
    {
        public Cartoons()
        {
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string [] Genre { get; set; }

        public string Summary { get; set; }

        public decimal Rating { get; set; }

        public string Thumbnail { get; set; }

        public string Trailer { get; set; }

        public string [] Images { get; set; }

        public int ReleaseYear { get; set; }

        public int StopYear { get; set; }

        public int Runtime { get; set; }


    }
}
