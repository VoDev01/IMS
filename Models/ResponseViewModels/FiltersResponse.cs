namespace IMS.Models.ResponseViewModels
{
    public class FiltersResponse
    {
        public IEnumerable<FiltersResponse_countries> Countries { get; set; }
        public IEnumerable<FiltersResponse_genres> Genres { get; set; }

        public class FiltersResponse_countries
        {
            public int Id { get; set; }
            public string Country { get; set; }

        }

        public class FiltersResponse_genres
        {
            public int Id { get; set; }
            public string Genre { get; set; }

        }
    }
}
