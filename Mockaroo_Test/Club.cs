using System.Text.Json.Serialization;

namespace Mockaroo_Test
{
    public class Club
    {
        public int Id { get; set; }

        [JsonPropertyName("club_name")]
        public string ClubName { get; set; }

        [JsonPropertyName("country_location")]
        public string CountryLocation { get; set; }

        [JsonPropertyName("stadium_capacity")]
        public int StadiumCapacity { get; set; }

        [JsonPropertyName("manager_name")]
        public string ManagerName { get; set; }

        [JsonPropertyName("founded_year")]
        public int FoundedYear { get; set; }

        [JsonPropertyName("league_affiliation")]
        public string LeagueAffiliation { get; set; }

        [JsonPropertyName("captain_name")]
        public string CaptainName { get; set; }

        [JsonPropertyName("jersey_color")]
        public string JerseyColor { get; set; }

        [JsonPropertyName("average_attendance")]
        public int AverageAttendance { get; set; }

        [JsonPropertyName("major_rival")]
        public string MajorRival { get; set; }
    }
}
