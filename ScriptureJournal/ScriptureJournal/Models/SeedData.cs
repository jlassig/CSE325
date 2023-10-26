using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;

namespace ScriptureJournal.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                if (context == null || context.Entry == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any entries.
                if (context.Entry.Any())
                {
                    return;   // DB has been seeded
                }
                context.Entry.AddRange(
                    new Entry
                    {
                        Reference = "1 Nephi 3:7",
                        EntryText = "Nephi is a great example of jumping in and getting it done. I should be like Nephi and get my homework done.",
                        Date = DateTime.Parse("2023-10-01"),

                    },
                    new Entry
                    {
                        Reference = "1 Nephi 7:3",
                        EntryText = "'Mr. Go and Do' went and did.",
                        Date = DateTime.Parse("2023-10-04"),

                    },
                    new Entry
                    {
                        Reference = "Isaiah 48:18",
                        EntryText = "How to find peace and happiness",
                        Date = DateTime.Parse("2023-10-03"),

                    },
                    new Entry
                    {
                        Reference = "Phillipians 1:3",
                        EntryText = "What a beautiful thing to say to another person.",
                        Date = DateTime.Parse("2023-10-04"),

                    },
                    new Entry
                    {
                        Reference = "John 3:4-5",
                        EntryText = "I'm glad people don't have to be 'born' again from a mother's womb! My kids are adults now. OUCH! I'm glad Jesus has a better way.",
                        Date = DateTime.Parse("2023-10-05"),

                    },
                    new Entry
                    {
                        Reference = "Revelation 14",
                        EntryText = "Each day brings us closer to the 2nd coming. ",
                        Date = DateTime.Parse("2023-10-06"),

                    },
                    new Entry
                    {

                        Reference = "D&C 2",
                        EntryText = "I need to make family history more of a priority.",
                        Date = DateTime.Parse("2023-10-07"),

                    },
                    new Entry
                    {

                        Reference = "D&C 2",
                        EntryText = "I need to make family history more of a priority.",
                        Date = DateTime.Parse("2023-10-07"),

                    }

                );
                context.SaveChanges();
            }

        }
    }
}

