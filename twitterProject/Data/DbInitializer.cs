using twitterProject.Models;
using System;
using System.Linq;

namespace twitterProject.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TwitterContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            //Add users on the time of DB creation
            var users = new User[]
            {
            new User{FirstName="Karan",LastName="Parmar", Email="kp@gmail.com", ImageUrl="https://media.licdn.com/dms/image/D5635AQHaH5_EpKkW9g/profile-framedphoto-shrink_400_400/0/1638213301423?e=1671825600&v=beta&t=vkkDOCrMZ8YYIg2ScIYTIxPiWSRkYDY-30vp4zMQDLs", Password="12345",},
             new User{FirstName="Elon",LastName="Musk", Email="elon@gmail.com",ImageUrl="https://avatars.githubusercontent.com/u/47338871?s=40&v=4" , Password="12345",},
              new User{FirstName="Evan",LastName="Luthra", Email="evan@gmail.com", ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmF89nCgOkgnehuhjstkS7yDKd4fXfvMFgSJFzBUO4hNltchvE1JNs&usqp=CAE&s", Password="12345",},
                new User{FirstName="Divyesh",LastName="Raj", Email="raj.divyesh2001@gmail.com", ImageUrl="https://avatars.githubusercontent.com/u/68767607?v=4", Password="12345",},
                new User{FirstName="Parth",LastName="Patel", Email="parth@gmail.com", ImageUrl="https://media.licdn.com/dms/image/C4E03AQFqg9fqByGiUA/profile-displayphoto-shrink_100_100/0/1516982089152?e=1676505600&v=beta&t=-ysEVXxzJLNkVkNKbEE7p0-5W8OMJO7FQ93lx-F7tAA", Password="12345",}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            //var tweets = new Tweet[]
            //{
            //new Tweet{ Description = "Hello", CreatedDate = DateTime.Parse("2001-09-01"), User = users[0]},
            //new Tweet{ Description = "Hi", CreatedDate = DateTime.Parse("2001-09-01"), User = users[1]}
            //new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            //new Course{CourseID=2042,Title="Literature",Credits=4}
            //};
            //foreach (Tweet c in tweets)
            //{
            //    context.Tweets.Add(c);
            //}
            //context.SaveChanges();
        }
    }
}