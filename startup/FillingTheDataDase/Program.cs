using CodeFirst;
using CodeFirst.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace FillingTheDataDase
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFirst.Classes.Context context = new Context();

            context.Spheres.AddOrUpdate(
                n => n.Name,
                new Sphere
                {
                    Name = "IT",
                    Categories = { "Web", "Mobile", "Desktop" },
                },
                 new Sphere
                 {
                     Name = "Retail",
                     Categories = { "Elecronics", "HealthAndBeauty", "ClothesAndAccessories" },
                 },
                 new Sphere
                 {
                     Name = "Restaurants",
                     Categories = { "Night", "Day", "AnticafeAndHookah" },
                 },
                 new Sphere
                 {
                     Name = "Production",
                     Categories = { "Food", "HandMade", "HeavyProduction" },
                 },
                 new Sphere
                 {
                     Name = "Services",
                     Categories = { "HealthAndBeauty", "Maintenance", "Business" }
                 }
                );


            context.Categories.AddOrUpdate(
                m => m.Name,
                new Category
                {
                    Name = "Web",
                    Sphere = "IT",
                    Keywords = { "web", "browser", "site", "page", "domain", "api", "digital", "shop", "com", "search" }

                },
                new Category
                {
                    Name = "Mobile",
                    Sphere = "IT",
                    Keywords = { "mobile", "app", "android", "ios", "iphone", "appstore", "market", "user", "ipad", "game" }


                }, new Category
                {
                    Name = "Desktop",
                    Sphere = "IT",
                    Keywords = { "laptop", "computer", "desktop", "screen", "integration", "companies", "office", "home", "application", "program" }

                }, new Category
                {
                    Name = "Elecronics",
                    Sphere = "Retail",
                    Keywords = { "electronics", "phones", "drones", "computers", "headphones", "newest", "devices", "it", "sensors", "technology" }

                }, new Category
                {
                    Name = "HealthAndBeauty",
                    Sphere = "Retail",
                    Keywords = { "health", "beauty", "food", "farm", "cosmetics", "organic", "care", "hygiene", "beverages", "eat" }

                }, new Category
                {
                    Name = "ClothesAndAccessories",
                    Sphere = "Retail",
                    Keywords = { "clothes", "accessories", "bags", "underwear", "sneakers", "t-shirt", "handcrafted", "shoes", "prints", "watches" }

                }, new Category
                {
                    Name = "Night",
                    Sphere = "Restaurants",
                    Keywords = { "night", "bar", "club", "alcohol", "drinks", "band ", "dj", "dance", "party", "pub" }

                }, new Category
                {
                    Name = "Day",
                    Sphere = "Restaurants",
                    Keywords = { "restaurant", "cafe", "coffee", "tea", "donuts", "burgers", "fastfood", "food", "pizza", "sushi" }

                }, new Category
                {
                    Name = "AnticafeAndHookah",
                    Sphere = "Restaurants",
                    Keywords = { "anticafe", "hookah", "shisha", "smoke", "lounge", "time", "games", "work", "board", "playstation" }

                }, new Category
                {
                    Name = "Food",
                    Sphere = "Production",
                    Keywords = { "food", "farm", "organic", "crops", "production", "healthy", "weight", "fat", "sugar", "plants" }

                }, new Category
                {
                    Name = "HandMade",
                    Sphere = "Production",
                    Keywords = { "style", "handmade", "toys", "accessories", "design", "handcrafted", "wood", "fabric", "leather", "decoration" }

                }, new Category
                {
                    Name = "HeavyProduction",
                    Sphere = "Production",
                    Keywords = { "manufacture", "production", "electronics", "research", "newest", "technology", "robots", "drones", "sensors", "devices" }

                }, new Category
                {
                    Name = "HealthAndBeauty",
                    Sphere = "Services",
                    Keywords = { "health", "beauty", "hair", "face", "nails", "clinic", "women", "style", "care", "salon" }

                }, new Category
                {
                    Name = "Maintenance",
                    Sphere = "Services",
                    Keywords = { "maintenance", "service", "repair", "fix", "home", "cars", "devices", "center", "workshop", "cleaning" }

                }, new Category
                {
                    Name = "Business",
                    Sphere = "Services",
                    Keywords = { "business", "law", "logistics", "finance", "accounting", "consulting", "programs", "deals", "bank", "exchange" }

                }
                );

            context.Answers.AddOrUpdate(
                p => p.Category,
                new Answer
                {
                    Category = "Web",
                    Text = "Your web-sites sounds almost as cool as Facebook. Or worse. To be honest, it is a lot worse - it’s a piece of shit and Mark Zuckerberg already said «What a loser!», though he doesn’t know you. And never will. Yeah, and good luck in never doing web-sites."
                },
                new Answer
                {
                    Category = "Mobile",
                    Text = "Oh, that’s a ground-breaking idea! Wait until you get 1 million downloads. Let me calculate, how much time is left before it happens… I already know the answer! It’s NEVER. Nobody needs this miserable app-parody on their phone. Get a real job, «startuper»."

                },
                new Answer
                {
                    Category = "Desktop",
                    Text = "That is some serious business indeed. I will send your contacts to investors as soon as possible. Oh, sorry, that wasn’t for you. I haven’t even read your program description and I already know, that it is either super awful, or Winows Vista level bad."

                },
                new Answer
                {
                    Category = "Elecronics",
                    Text = "I know, I know, that you are a star-wars fan, and you love drones and shit. But the fact, that you are a board-game lover does not mean, that you can make electronics business."

                },
                new Answer
                {
                    Category = "HealthAndBeauty",
                    Text = "Here’s an interesting fact. You do not need to create the beauty retail to buy the acne cream. Unexpected, isn’t it? You just go to the local shop and buy it - you, little shy teenager. Oh, almost forgot, your idea is bad. Almost as bad as your face."

                },
                new Answer
                {
                    Category = "ClothesAndAccessories",
                    Text = "No, no, no! You can not sell all this shit for hundreds dollars! I doubt that you can sell anything at all. And again: wearing those ugly sneakers and teared jeans doesn’t mean that you know a single bit about fashion."


                },
                new Answer
                {
                    Category = "Night",
                    Text = "Soo, you are a teenager or a heavy drinker, right? Oh, boy… Go get drunk fast, and do not interrupt adults - we’re trying to do business here. Go, kid! Back in my days stupid underaged teens and alcoholics were told to shut up when adults talk."

                },
                new Answer
                {
                    Category = "Day",
                    Text = "I’m very glad to meet a real professional chef. Just kidding. Do you even know how to cook? No, cereal and sandwiches don’t count. Maybe you want to first finish the education before poisoning people? That’s it, go away and never return with such dumb ideas."

                },
                new Answer
                {
                    Category = "AnticafeAndHookah",
                    Text = "WOW, such a new idea! Never heard of it before. You should go and start making it right this moment! You know, that’s not true, right? Then why the fuck do you propose such stupid ideas? Create something a little original and come back. No, don’t."

                },
                new Answer
                {
                    Category = "Food",
                    Text = "Here we go again! Let me guess: you are a vegan or an enviromentalist. Either way, I have some bad news for you. Nobody likes faggots. Your idea maybe green, organic and gluten-free, but it is still very gay. Oh, you are offended? Sorry, Mr. Faggot."

                },
                new Answer
                {
                    Category = "HandMade",
                    Text = "Have you tried selling these to somebody? Well, try to understand this. Only your mother thinks that your handmade rubbish is «wonderful». Clients usually call it «useless pieces of shit». Yeah, you have read that correctly. Nobody will buy this, ever. Except your mother."

                },
                new Answer
                {
                    Category = "HeavyProduction",
                    Text = "Do you know, that you need actual money to start producing something? No, those 200$ you saved will not help you. Why don’t you find some easy work, huh? Real business is too hard for such a person as you are."

                },
                new Answer
                {
                    Category = "HealthAndBeauty",
                    Text = "That would be a very nice idea to make people more healthy and pretty. Unless it was invented by someone as fat and ugly as you. I mean, look at yourself! I will send this to your better-looking competitors. Like me, not you."

                },
                new Answer
                {
                    Category = "Maintenance",
                    Text = "So, you’ve always dreamed to be a plumber or a janitor? Or you like to repair stuff much? Now your dreams may come true - that’s what your business about - is it? Go on - make the world better by cleaning shit after somebody"

                },
                new Answer
                {
                    Category = "Business",
                    Text = "Sorry for disturbing you, mr. businessman. I just wanted to kindly remind you that your business is a little bit unoriginal. Let me be a bit more clear: THIS SHIT IS EVERYWHERE! Go make something a little distinctive, for God’s sake!"

                }

                );

          





        }
    }
}
