namespace HockeyStats.Models
{
    public class Referee
    {
        public int Id { get; set; }

        public string RefereeName { get; set; }

        public string IdentityUserId { get; set; }

        public RefType RefType { get; set; }
        public int? RefTypeId { get; set; }

        public RefCategory RefCategory { get; set; }
        public int? RefCategoryId { get; set; }

        public RefCategoryType RefCategoryType { get; set; }
        public int? RefCategoryTypeId { get; set; }

        public RefDistrikt RefDistrikt { get; set; }
        public int? RefDistriktId { get; set; }
    }
}