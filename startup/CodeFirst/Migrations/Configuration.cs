namespace CodeFirst.Migrations
{
    using Classes;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.Classes.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.Classes.Context context)
        {
            List<Sphere> data = new List<Sphere>()
            {
                new Sphere(){Name = "IT"},
                new Sphere(){Name = "Retail" },
                new Sphere(){Name = "Restaurants" },
                new Sphere(){Name = "Production" },
                new Sphere(){Name = "Services" }
            };
            data.ForEach(s => context.Spheres.Add(s));
            context.SaveChanges();

            List<Category> category = new List<Category>()
            {
                new Category(){Name = "Web", Keywords = { "web", "browser", "site", "page", "domain", "api", "digital", "shop", "com", "search" },
                    Sphere = context.Spheres.FirstOrDefault(x => x.Name == "IT")},
                new Category(){Name = "Mobile", Keywords = { "mobile", "app", "android", "ios", "iphone", "appstore", "market", "user", "ipad", "game" },
                    Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Retail") },
                new Category(){Name = "Desktop", Keywords = { "laptop", "computer", "desktop", "screen", "integration", "companies", "office", "home", "application", "program" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "IT")},
                new Category(){ Name = "Elecronics", Keywords = { "electronics", "phones", "drones", "computers", "headphones", "newest", "devices", "it", "sensors", "technology" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Retail")},
                new Category(){ Name = "HealthAndBeauty", Keywords = { "health", "beauty", "food", "farm", "cosmetics", "organic", "care", "hygiene", "beverages", "eat" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Retail")},
                new Category(){ Name = "ClothesAndAccessories", Keywords = { "clothes", "accessories", "bags", "underwear", "sneakers", "t-shirt", "handcrafted", "shoes", "prints", "watches" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Retail")},
                new Category(){ Name = "Night", Keywords = { "night", "bar", "club", "alcohol", "drinks", "band ", "dj", "dance", "party", "pub" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Restaurants")},
                new Category(){ Name = "Day", Keywords = { "restaurant", "cafe", "coffee", "tea", "donuts", "burgers", "fastfood", "food", "pizza", "sushi" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Restaurants")},
                new Category(){ Name = "AnticafeAndHookah", Keywords = { "anticafe", "hookah", "shisha", "smoke", "lounge", "time", "games", "work", "board", "playstation" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Restaurants")},
                new Category(){ Name = "Food", Keywords = { "food", "farm", "organic", "crops", "production", "healthy", "weight", "fat", "sugar", "plants" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Production")},
                new Category(){Name = "HandMade", Keywords = { "style", "handmade", "toys", "accessories", "design", "handcrafted", "wood", "fabric", "leather", "decoration" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Production")},
                new Category(){ Name = "HeavyProduction", Keywords = { "manufacture", "production", "electronics", "research", "newest", "technology", "robots", "drones", "sensors", "devices" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Production")},
                new Category(){ Name = "HealthAndBeauty", Keywords = { "health", "beauty", "hair", "face", "nails", "clinic", "women", "style", "care", "salon" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Services")},
                new Category(){ Name = "Maintenance", Keywords = { "maintenance", "service", "repair", "fix", "home", "cars", "devices", "center", "workshop", "cleaning" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Services")},
                new Category(){Name = "Business", Keywords = { "business", "law", "logistics", "finance", "accounting", "consulting", "programs", "deals", "bank", "exchange" },
                   Sphere = context.Spheres.FirstOrDefault(x => x.Name == "Services")}
            };
            category.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();

            List<Answer> answer = new List<Answer>()
            {
                new Answer(){ Text = "Your web-sites sounds almost as cool as Facebook. Or worse. To be honest, it is a lot worse - it’s a piece of shit and Mark Zuckerberg already said «What a loser!», though he doesn’t know you. And never will. Yeah, and good luck in never doing web-sites.", 
                Category = context.Categories.FirstOrDefault(x => x.Name == "Web")},
                new Answer(){ Text = "Oh, that’s a ground-breaking idea! Wait until you get 1 million downloads. Let me calculate, how much time is left before it happens… I already know the answer! It’s NEVER. Nobody needs this miserable app-parody on their phone. Get a real job, «startuper».",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Mobile")},
                new Answer(){  Text = "That is some serious business indeed. I will send your contacts to investors as soon as possible. Oh, sorry, that wasn’t for you. I haven’t even read your program description and I already know, that it is either super awful, or Winows Vista level bad.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Desktop")},
                 new Answer(){ Text = "I know, I know, that you are a star-wars fan, and you love drones and shit. But the fact, that you are a board-game lover does not mean, that you can make electronics business.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Elecronics")},
                  new Answer(){ Text = "Here’s an interesting fact. You do not need to create the beauty retail to buy the acne cream. Unexpected, isn’t it? You just go to the local shop and buy it - you, little shy teenager. Oh, almost forgot, your idea is bad. Almost as bad as your face.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "HealthAndBeauty")},
                   new Answer(){ Text = "No, no, no! You can not sell all this shit for hundreds dollars! I doubt that you can sell anything at all. And again: wearing those ugly sneakers and teared jeans doesn’t mean that you know a single bit about fashion.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "ClothesAndAccessories")},
                    new Answer(){ Text = "Soo, you are a teenager or a heavy drinker, right? Oh, boy… Go get drunk fast, and do not interrupt adults - we’re trying to do business here. Go, kid! Back in my days stupid underaged teens and alcoholics were told to shut up when adults talk.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Night")},
                     new Answer(){  Text = "I’m very glad to meet a real professional chef. Just kidding. Do you even know how to cook? No, cereal and sandwiches don’t count. Maybe you want to first finish the education before poisoning people? That’s it, go away and never return with such dumb ideas.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Day")},
                      new Answer(){  Text = "WOW, such a new idea! Never heard of it before. You should go and start making it right this moment! You know, that’s not true, right? Then why the fuck do you propose such stupid ideas? Create something a little original and come back. No, don’t.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "AnticafeAndHookah")},
                       new Answer(){ Text = "Here we go again! Let me guess: you are a vegan or an enviromentalist. Either way, I have some bad news for you. Nobody likes faggots. Your idea maybe green, organic and gluten-free, but it is still very gay. Oh, you are offended? Sorry, Mr. Faggot.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Food")},
                        new Answer(){ Text = "Have you tried selling these to somebody? Well, try to understand this. Only your mother thinks that your handmade rubbish is «wonderful». Clients usually call it «useless pieces of shit». Yeah, you have read that correctly. Nobody will buy this, ever. Except your mother.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "HandMade")},
                         new Answer(){ Text = "Do you know, that you need actual money to start producing something? No, those 200$ you saved will not help you. Why don’t you find some easy work, huh? Real business is too hard for such a person as you are.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "HeavyProduction")},
                          new Answer(){  Text = "That would be a very nice idea to make people more healthy and pretty. Unless it was invented by someone as fat and ugly as you. I mean, look at yourself! I will send this to your better-looking competitors. Like me, not you.",
                Category = context.Categories.FirstOrDefault(x => x.Name == "HealthAndBeauty")},
                           new Answer(){ Text = "So, you’ve always dreamed to be a plumber or a janitor? Or you like to repair stuff much? Now your dreams may come true - that’s what your business about - is it? Go on - make the world better by cleaning shit after somebody",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Maintenance")},
                           new Answer(){ Text = "Sorry for disturbing you, mr. businessman. I just wanted to kindly remind you that your business is a little bit unoriginal. Let me be a bit more clear: THIS SHIT IS EVERYWHERE! Go make something a little distinctive, for God’s sake!",
                Category = context.Categories.FirstOrDefault(x => x.Name == "Business")}
            };
            answer.ForEach(s => context.Answers.Add(s));
            context.SaveChanges();

        }
    }
}

//  This method will be called after migrating to the latest version.

//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
//  to avoid creating duplicate seed data. E.g.
//
//    context.People.AddOrUpdate(
//      p => p.FullName,
//      new Person { FullName = "Andrew Peters" },
//      new Person { FullName = "Brice Lambson" },
//      new Person { FullName = "Rowan Miller" }
//    );
//