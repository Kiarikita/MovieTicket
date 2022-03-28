using eBiletix.Data.Enums;
using eBiletix.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletix.Data
{ 
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //dependency injection
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated(); //databasein varolduğundan emin ol

                //Cinema
                if (!context.Cinemas.Any())//herhangi bir kayıt yok ise
                {
                    context.Cinemas.AddRange(new List<Cinema>() 
                    {
                        new Cinema()
                        {
                        Name = "Cinema 1",
                        Logo = "~Content\\img\\cinemaLogo\\alamo.png",
                        Description = "Alamo Sineması"
                        },
                        new Cinema()
                        {
                        Name = "Cinema 2",
                        Logo = "~Content\\img\\cinemaLogo\\avsar.jpg",
                        Description = "Avşar Sineması "
                        },
                        new Cinema()
                        {
                        Name = "Cinema 3",
                        Logo = "~Content\\img\\cinemaLogo\\cineatlas.jpg",
                        Description = "CineAtlas Sineması "
                        },
                        new Cinema()
                        {
                        Name = "Cinema 4",
                        Logo = "~Content\\img\\cinemaLogo\\cinemax.png",
                        Description = "Cinemax Sineması "
                        },
                        new Cinema()
                        {
                        Name = "Cinema 5",
                        Logo = "~Content\\img\\cinemaLogo\\cinemaximum.jpeg",
                        Description = "Cinemaximum Sineması "
                        }
                    });
                    context.SaveChanges();

                }

                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Catherine Zeta-Jones",
                            Bio = "Catherine Zeta-Jones Biyografi",
                            ProfilePictureURL = ""
                        },
                        new Actor()
                        {
                            FullName = "Dwayne Johnson",
                            Bio = "Dwayne Johnson Biyografi",
                            ProfilePictureURL = ""
                        },
                        new Actor()
                        {
                            FullName = "Gal Gadot",
                            Bio = "Gal Gadot Biyografi",
                            ProfilePictureURL = ""
                        },
                        new Actor()
                        {
                            FullName = "Keanu Reeves",
                            Bio = "Keanu Reeves Biyografi",
                            ProfilePictureURL = ""

                        },
                        new Actor()
                        {
                            FullName = "Kristen Stewart",
                            Bio = "Kristen Stewart Biyografi",
                            ProfilePictureURL = ""
                        },
                        new Actor()
                        {
                            FullName = "Tom Hanks",
                            Bio = "Tom Hanks Biyografi",
                            ProfilePictureURL = ""
                        }

                    });
                    context.SaveChanges();
                }

                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Deborah Snyder",
                            Bio = "Deborah Snyder Biografi",
                            ProfilePictureURL = "~Content\\img\\producer\\deborahSnyder.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Frank Darabont",
                            Bio = "Frank Darabont Biografi",
                            ProfilePictureURL = "~Content\\img\\producer\\frankdarabont.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Hiram Garcia",
                            Bio = "Hiram Garcia Biografi",
                            ProfilePictureURL = "~Content\\img\\producer\\hiramGarcia.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Lana Wachowski",
                            Bio = "Lana Wachowski Biografi",
                            ProfilePictureURL = "~Content\\img\\producer\\LanaWachowski.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Martin Campbell",
                            Bio = "Martin Campbell Biografi",
                            ProfilePictureURL = "~Content\\img\\producer\\martinCampbell.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Wyck Godfrey",
                            Bio = "Wyck Godfrey Biografi",
                            ProfilePictureURL = "~Content\\img\\producer\\WyckGodfrey.jpg"
                        }

                    });
                    context.SaveChanges();
                }

                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "The Green Mile",
                            Description = "The Green Mile Açıklaması",
                            Price = 25.00,
                            ImageURL = "~Content\\img\\film\\greenMile.jpg",
                            StartDate = DateTime.Now,
                            EndDate =DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama

                        },

                        new Movie()
                        {
                            Name = "Matrix",
                            Description = "Matrix Açıklaması",
                            Price = 25.00,
                            ImageURL = "~Content\\img\\film\\matrix.jpg",
                            StartDate = DateTime.Now,
                            EndDate =DateTime.Now.AddDays(10),
                            CinemaId = 2,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.ScienceFiction

                        },
                        
                        new Movie()
                        {
                            Name = "Skyscraper",
                            Description = "Skyscraper Açıklaması",
                            Price = 25.00,
                            ImageURL = "~Content\\img\\film\\skyscraper.jpg",
                            StartDate = DateTime.Now,
                            EndDate =DateTime.Now.AddDays(3),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action

                        },
                        new Movie()
                        {
                            Name = "Twilight",
                            Description = "Twilight Açıklaması",
                            Price = 25.00,
                            ImageURL = "~Content\\img\\film\\twilight.jpg",
                            StartDate = DateTime.Now,
                            EndDate =DateTime.Now.AddDays(5),
                            CinemaId = 4,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Romance

                        },

                        new Movie()
                        {
                            Name = "Wonder Woman",
                            Description = "Wonder Woman Açıklaması",
                            Price = 25.00,
                            ImageURL = "~Content\\img\\film\\wonderWoman.jpg",
                            StartDate = DateTime.Now,
                            EndDate =DateTime.Now.AddDays(5),
                            CinemaId = 5,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action

                        },
                        new Movie()
                        {
                            Name = "The Legend of Zorro",
                            Description = "The Legend of Zorro Açıklaması",
                            Price = 25.00,
                            ImageURL = "~Content\\img\\film\\zorro.jpg",
                            StartDate = DateTime.Now,
                            EndDate =DateTime.Now.AddDays(5),
                            CinemaId = 4,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Action

                        }

                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>() 
                    { 
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

    }
}
