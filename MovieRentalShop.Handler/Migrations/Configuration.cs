namespace MovieRentalShop.Handler.Migrations
{
    using MovieRentalShop.Handler.Context;
    using MovieRentalShop.Handler.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieRentalShop.Handler.Context.MovieRentalShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MovieRentalShopContext context)
        {
            var movies = MovieSeed();
            foreach (var m in movies)
            {
                context.Movies.Add(m);
            }


            base.Seed(context);
        }

        /// <summary>
        /// From http://www.imdb.com/list/ls074818782/
        /// </summary>
        private List<Movie> MovieSeed()
        {
            var movies = new List<Movie>
            {
                new Movie { 
                    Name = "Ghost in the Shell 2: Innocence",
                    Imdb = 7.6f,
                    Year = 2004,
                    Description = "In the year 2032, Batô, a cyborg detective for the anti-terrorist unit Public Security Section 9, investigates the case of a female robot--one created solely for sexual pleasure--who slaughtered her owner. (100 mins.)",
                    ImageUrl = "Ghost in the Shell 2 Innocence (2004).jpg"
                },
                new Movie { 
                    Name = "Zootopia",
                    Imdb = 8.1f,
                    Year = 2016,
                    Description = "In a city of anthropomorphic animals, a rookie bunny cop and a cynical con artist fox must work together to uncover a conspiracy. (108 mins.)",
                    ImageUrl = "Zootopia (2016).jpg"
                },
                new Movie { 
                    Name = "Spirited Away",
                    Imdb = 8.6f,
                    Year = 2001,
                    Description = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.",
                    ImageUrl = "Spirited Away (2001).jpg"
                },
                new Movie { 
                    Name = "Inside Out",
                    Imdb = 8.2f,
                    Year = 2015,
                    Description = "After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school.",
                    ImageUrl = "Inside Out (2015).jpg"
                },
                new Movie { 
                    Name = "Anomalisa",
                    Imdb = 7.3f,
                    Year = 2015,
                    Description = "A man crippled by the mundanity of his life experiences something out of the ordinary.",
                    ImageUrl = "Anomalisa (2015)"
                },
                new Movie { 
                    Name = "WALL·E",
                    Imdb = 8.4f,
                    Year = 2008,
                    Description = "In the distant future, a small waste-collecting robot inadvertently embarks on a space journey that will ultimately decide the fate of mankind.",
                    ImageUrl = "WALL·E (2008)"
                },
                new Movie { 
                    Name = "Toy Story 3",
                    Imdb = 8.3f,
                    Year = 2010,
                    Description = "The toys are mistakenly delivered to a day-care center instead of the attic right before Andy leaves for college, and it's up to Woody to convince the other toys that they weren't abandoned and to return home.",
                    ImageUrl = "Toy Story 3 (2010).jpg"
                },
                new Movie { 
                    Name = "Up",
                    Imdb = 8.3f,
                    Year = 2009,
                    Description = "Seventy-eight year old Carl Fredricksen travels to Paradise Falls in his home equipped with balloons, inadvertently taking a young stowaway.",
                    ImageUrl = "Up (2009).jpg"
                },
                new Movie { 
                    Name = "Howl's Moving Castle",
                    Imdb = 8.2f,
                    Year = 2004,
                    Description = "When an unconfident young woman is cursed with an old body by a spiteful witch, her only chance of breaking the spell lies with a self-indulgent yet insecure young wizard and his companions in his legged, walking castle.",
                    ImageUrl = "Howl's Moving Castle (2004).jpg"
                }
            };

            return movies;
        }
    }
}
