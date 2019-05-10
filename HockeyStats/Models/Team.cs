namespace HockeyStats.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string TeamName { get; set; }

        public int? ClubId { get; set; }
    }
}