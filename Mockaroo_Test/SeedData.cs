using System.Text.Json;

namespace Mockaroo_Test
{
    public class SeedData
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (context.Clubs.Any()) return;

            var json = await File.ReadAllTextAsync("MOCK_DATA.json");
            var clubs = JsonSerializer.Deserialize<List<Club>>(json);

            context.Clubs.AddRange(clubs!);
            await context.SaveChangesAsync();
        }
    }
}
