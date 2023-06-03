using Microsoft.EntityFrameworkCore;
using myDB.Data;

namespace myDB.Models
{
    public class SeedData
    {
        private static int length = 5;

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new myDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<myDBContext>>());
            // Look for any movies.
            if (context.Publication.Any())
            {
                return;   // DB has been seeded
            }

            var publicationList = new List<Publication>();

            for (int i = 0; i < length; i++)
            {
                var publication = new Publication
                {
                    Title = "Заголовок " + i,
                    Description = "Опис " + i,
                };

                publicationList.Add(publication);
            }

            context.Publication.AddRange(publicationList);
            context.SaveChanges();
        }
    }
}
