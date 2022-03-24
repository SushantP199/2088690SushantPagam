namespace MovieCruiser.Api.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        public int MovieListId { get; set; }

        public int UserId { get; set; }
    }
}
