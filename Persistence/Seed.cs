using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context,
            UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        Id = "a",
                        DisplayName = "syazwan",
                        UserName = "syazwan",
                        Email = "syazwan@test.com"
                    },
                    new AppUser
                    {
                        Id = "b",
                        DisplayName = "alif",
                        UserName = "alif",
                        Email = "alif@test.com"
                    },
                    new AppUser
                    {
                        Id = "c",
                        DisplayName = "fatin",
                        UserName = "fatin",
                        Email = "fatin@test.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Qwerty12345!");
                }
            }

            if (!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Makan McD bersama kawan",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Makan McD bersama kawan",
                        Category = "Drinks",
                        City = "Kuala Lumpur",
                        Venue = "McD",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(-2)
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Programming Class",
                        Date = DateTime.Now.AddMonths(-1),
                        Description = "Programming class with new friends",
                        Category = "Culture",
                        City = "Bangi",
                        Venue = "The Hangout",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "b",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(-1)
                            },
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(-1)
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Konsert",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "Konser rock ooo",
                        Category = "Music",
                        City = "Kuala Lumpur",
                        Venue = "Hard Rock Cafe",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "b",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(1)
                            },
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(1)
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Lepak Makan",
                        Date = DateTime.Now.AddMonths(2),
                        Description = "Makan sama2",
                        Category = "Food",
                        City = "Kajang",
                        Venue = "Warung Pak Hassan",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "c",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(2)
                            },
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(2)
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Party like a rock star",
                        Date = DateTime.Now.AddMonths(3),
                        Description = "Party like a rock star",
                        Category = "Drinks",
                        City = "TTDI",
                        Venue = "Club Happy",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "b",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(3)
                            },
                            new UserActivity
                            {
                                AppUserId = "c",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(3)
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Hangout in a museum",
                        Date = DateTime.Now.AddMonths(4),
                        Description = "Hangout in a museum",
                        Category = "Culture",
                        City = "Kajang",
                        Venue = "Museum",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(4)
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Minum and lepak",
                        Date = DateTime.Now.AddMonths(5),
                        Description = "Minum and lepak tgk Manchester United",
                        Category = "Drinks",
                        City = "Manchester",
                        Venue = "Old Trafford",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "c",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(5)
                            },
                            new UserActivity
                            {
                                AppUserId = "b",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(5)
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Majlis Nasyid",
                        Date = DateTime.Now.AddMonths(6),
                        Description = "Majlis Nasyid",
                        Category = "Music",
                        City = "Nilai",
                        Venue = "Masjid",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(6)
                            },
                            new UserActivity
                            {
                                AppUserId = "b",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(6)
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Hiking with friends",
                        Date = DateTime.Now.AddMonths(7),
                        Description = "Hiking with friends",
                        Category = "Travel",
                        City = "Semenyih",
                        Venue = "Bukit Broga",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(7)
                            },
                            new UserActivity
                            {
                                AppUserId = "c",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(7)
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Wine tasting",
                        Date = DateTime.Now.AddMonths(8),
                        Description = "Wine tasting with new friends",
                        Category = "Drinks",
                        City = "Kuala Lumpur",
                        Venue = "Wine place",
                        UserActivities = new List<UserActivity>
                        {
                            new UserActivity
                            {
                                AppUserId = "b",
                                IsHost = true,
                                DateJoined = DateTime.Now.AddMonths(8)
                            },
                            new UserActivity
                            {
                                AppUserId = "a",
                                IsHost = false,
                                DateJoined = DateTime.Now.AddMonths(8)
                            },
                        }
                    }
                };

                await context.Activities.AddRangeAsync(activities);
                await context.SaveChangesAsync();
            }
        }
    }
}