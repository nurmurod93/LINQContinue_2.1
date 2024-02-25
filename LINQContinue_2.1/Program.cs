using LINQContinue_2._1;

//var markets = new List<Market>()
//{
//    new Market() { Id =1, Name = "Korzinka", Items = new string[] { "kivi", "cherry", "banana" } },
//    new Market() { Id = 2, Name = "Makro", Items = new string[] { "melon", "mango", "olive" } },
//    new Market() { Id = 3, Name = "Azia", Items = new string[] { "kivi", "apple", "orange" } },
//    new Market() { Id = 4, Name = "Andalus", Items = new string[] { "grape", "watermalon", "pomegranate" } },
//    new Market() { Id = 5, Name = "Havas", Items = new string[] { "avacado", "pineapple", "papaya" } },
//    new Market() { Id = 6, Name = "Baraka", Items = new string[] { "pear", "lemon", "plum"} },

//};




//var names = (from market in markets
//             where market.Items.All(item => item.Length == 5)
//             select market.Name).ToList();

//var namesQuery = markets.Where(m => m.Items.All(i => i.Length == 5))
//                           .Select(m => m.Name)
//                           .ToList();

//namesQuery.ForEach(name => Console.WriteLine(name));

//var names = (from market in markets
//             where market.Items.Any(Item => Item.Length == 5)
//             select market.Name).ToList();

//names.ForEach(name => Console.WriteLine(name));

//var namesQuery2 = markets.Where(m => m.Items.Any(i => i.Length == 5))
//                          .Select(m => m.Name)
//                          .ToList();

//namesQuery2.ForEach(name => Console.WriteLine(name));

//names.ForEach(name => Console.WriteLine(name));



//var newMarkets = markets.Where(m => m.Items.Any(i => i.Length == 5))
//                        .Select(m => new Market { Id = m.Id, Name = m.Name + "market", Items = m.Items })
//                        .ToList();

//newMarkets.ForEach(m =>
//{
//    Console.WriteLine($"{m.Id}. {m.Name}");
//    Array.ForEach(m.Items, i => Console.WriteLine(i));
//    Console.WriteLine();
//});


//var words = new List<string>() { "an", "apple", "a", "day" };

//var query = words.Select(x => x.Substring(0, 1));

//foreach (var word in query)
//{
//    Console.WriteLine(word);
//}

//var otherMarkets = new List<Market>()
//{
//    new Market() { Id =1, Name = "Korzinka", Items = new string[] { "kivi, cherry, banana", "shirt, jacet, trousers", "bread, cake, toast"} },
//    new Market() { Id = 2, Name = "Makro", Items = new string[] { "melon, mango, olive", "jumper, coat, jeans", "sandwitch, biscuit, cookies"} },
//    new Market() { Id = 3, Name = "Azia", Items = new string[] { "kivi, apple, orange", "sweatshirt, t-shirt, polo shirt", "bagel, roll, pie" } },
//    new Market() { Id = 4, Name = "Andalus", Items = new string[] { "grape, watermalon, pomegranate", "suit, hoodie, dress", "pancake, crackers, doughnuts" } },
//    new Market() { Id = 5, Name = "Havas", Items = new string[] { "avacado, pineapple, papaya", "skirts, boxers, cap", "lavash, hamburger, kebab" } },
//    new Market() { Id = 6, Name = "Baraka", Items = new string[] { "pear, lemon, plum", "hat, slippers, tie", "hotdog, cheeseburger, burger"} },

//};

//var otherNewMarkets = from market in otherMarkets
//                      from items in market.Items
//                      from item in items.Split(',')
//                      orderby item.Length
//                      select item;
//foreach(var item in otherNewMarkets)
//{
//    Console.WriteLine(item);
//}


//var othermMrketsQuery = otherMarkets.SelectMany(m => m.Items.SelectMany((i) => i.Split(','))).OrderBy(i => i.Length);

//foreach(var item in othermMrketsQuery)
//{
//    Console.WriteLine(item);
//}

//var phrases = new List<string>() { "an apple a day", "the quick fox" };
//var query2 = phrases.SelectMany((p) => p.Split(' '));

//var sorov = from phrase in phrases
//            from word in phrase.Split(' ')
//            select word;
//foreach(var p in sorov)
//    Console.WriteLine(p);

//var superMarkets = new List<Market>()
//{
//    new Market() { Id =1, Name = "Korzinka", Items = new string[] { "kivi", "cherry", "banana" } },
//    new Market() { Id = 2, Name = "Makro", Items = new string[] { "melon", "mango", "olive" } },
//    new Market() { Id = 3, Name = "Azia", Items = new string[] { "kivi", "apple", "orange" } },
//    new Market() { Id = 4, Name = "Andalus", Items = new string[] { "grape", "watermalon", "pomegranate" } },
//    new Market() { Id = 5, Name = "Havas", Items = new string[] { "avacado", "pineapple", "papaya" } },
//    new Market() { Id = 6, Name = "Baraka", Items = new string[] { "pear", "lemon", "plum"} },

//};

//IEnumerable<string[]> query1 = superMarkets.Select(x => x.Items);

//foreach (var items in query1)
//{
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}

//IEnumerable<string> query2 = superMarkets.SelectMany(x => x.Items);

//foreach (var items in query2)
//{
//    Console.WriteLine(items);
//}

