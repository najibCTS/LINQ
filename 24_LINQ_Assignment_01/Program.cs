using System;
using System.Collections.Generic;
using System.Linq;

namespace _24_LINQ_Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.
            //Console.WriteLine("Find the cube of the numbers that are greater than 100 but less than 1000 using LINQ");

            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int[] result = intArray.Where(a => a * a * a > 100 && a * a * a < 1000).ToArray();
            Console.WriteLine("Input: " + string.Join(" ", intArray));
            //Console.WriteLine("Output: " + string.Join(" ", result));

            //intArray = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //result = intArray.Where(a => a * a * a > 100 && a * a * a < 1000).ToArray();
            //Console.WriteLine("Input: " + string.Join(" ", intArray));
            //Console.WriteLine("Output: " + string.Join(" ", result));

            //2.
            //Console.WriteLine("Tennis Tournament");
            //List<Player> playerList = new List<Player> { new Player { Name = "Roger Federer", Country = "Switzerland" },
            //                                             new Player { Name = "Rafael Nadal", Country = "Spain" },
            //                                             new Player { Name = "Novak Djokovic", Country = "Serbia" },
            //                                             new Player { Name = "Andy Murray", Country = "England" },
            //                                             new Player { Name = "David Ferrer", Country = "Spain" },
            //                                             new Player { Name = "Stan Wawrinka", Country = "Switzerland" }};

            //List<Player> groupA = playerList.Take(playerList.Count / 2).ToList();
            //List<Player> groupB = playerList.Skip(playerList.Count / 2).ToList();
            //List<string> schedule = new List<string>();
            //groupA.ForEach(a => { groupB.ForEach(b => { if (a.Country != b.Country) { schedule.Add(a.Name + " vs "+b.Name); } });  });

            //Console.WriteLine("Input:");
            //playerList.ForEach(a=> Console.WriteLine(a.Name+ " "+a.Country));
            //Console.WriteLine("\nGroup A:");
            //groupA.ForEach(a => Console.WriteLine(a.Name + " " + a.Country));
            //Console.WriteLine("\nGroup B:");
            //groupB.ForEach(a => Console.WriteLine(a.Name + " " + a.Country));
            //Console.WriteLine("\nOutput:\n" + string.Join("\n", schedule));

            //3.
            //List<Order> orderCollection = new List<Order>
            //{
            //    new Order{ OrderId=1, ItemName="Mobile", OrderDate= DateTime.Parse("01-08-2010"), Quantity=10},
            //    new Order{ OrderId=2, ItemName="TV", OrderDate= DateTime.Parse("05-09-2016"), Quantity=45},
            //    new Order{ OrderId=3, ItemName="Car", OrderDate= DateTime.Parse("01-01-2000"), Quantity=30},
            //    new Order{ OrderId=4, ItemName="Laptop", OrderDate= DateTime.Parse("07-10-2015"), Quantity=0},
            //    new Order{ OrderId=5, ItemName="AC", OrderDate= DateTime.Parse("02-07-2013"), Quantity=80},
            //    new Order{ OrderId=6, ItemName="Modem", OrderDate= DateTime.Parse("09-05-2018"), Quantity=54},
            //    new Order{ OrderId=7, ItemName="Mouse", OrderDate= DateTime.Parse("06-02-2019"), Quantity=87},
            //    new Order{ OrderId=8, ItemName="Keyboard", OrderDate= DateTime.Parse("05-09-2013"), Quantity=321},
            //};

            //Console.WriteLine("Input:");
            ////Console.WriteLine("Order:");
            //orderCollection.ForEach(a => { Console.WriteLine(a.OrderId + " | " + a.ItemName + " | " + a.OrderDate + " | " + a.Quantity); });
            //Console.WriteLine("\nMost recently ordered to least recently ordered :");
            //orderCollection.OrderByDescending(a => a.OrderDate).ToList().ForEach(a => { Console.WriteLine(a.OrderId + " | " + a.ItemName + " | " + a.OrderDate + " | " + a.Quantity); });
            //Console.WriteLine("\nQuantity from highest to lowest :");
            //orderCollection.OrderByDescending(a => a.Quantity).ToList().ForEach(a => { Console.WriteLine(a.OrderId + " | " + a.ItemName + " | " + a.OrderDate + " | " + a.Quantity); });

            ////4. 
            //Console.WriteLine("\nGrouped by the month in the descending order of the order date:");
            //orderCollection.OrderByDescending(a => a.OrderDate).GroupBy(b => b.OrderDate.Month).SelectMany(c => c).ToList().ForEach(d => { Console.WriteLine(d.OrderId + " | " + d.ItemName + " | " + d.OrderDate + " | " + d.Quantity); });

            //5.
            //List<Item> itemCollection = new List<Item>
            //{
            //    new Item{ ItemName = "Mobile", Price=3000},
            //    new Item{ ItemName = "TV", Price=12000},
            //    new Item{ ItemName = "Car", Price=50000},
            //    new Item{ ItemName = "Laptop", Price=20000},
            //    new Item{ ItemName = "AC", Price=35000},
            //    new Item{ ItemName = "Modem", Price=2000},
            //    new Item{ ItemName = "Mouse", Price=300},
            //    new Item{ ItemName = "Keyboard", Price=500}
            //};
            //Console.WriteLine("Item:");
            //itemCollection.ForEach(a => { Console.WriteLine(a.ItemName + " | " + a.Price); });

            //Console.WriteLine("\nOrder and Item details:");
            //orderCollection.Join(itemCollection, a => a.ItemName, b => b.ItemName, (order, item) => new Order { OrderId= order.OrderId,  ItemName=item.ItemName,  OrderDate=order.OrderDate, Quantity = (item.Price * order.Quantity) }).GroupBy(c=>c.OrderDate.Month).SelectMany(d=>d).ToList().OrderByDescending(e=>e.OrderDate).ToList().ForEach(f => { Console.WriteLine(f.OrderId + " | " + f.ItemName + " | " + f.OrderDate + " | " + f.Quantity); });

            //6.
            //Console.WriteLine("\nWith Anonymous Types:");
            //orderCollection.Join(itemCollection, a => a.ItemName, b => b.ItemName, (order, item) => new { order.OrderId, item.ItemName, order.OrderDate, TotalPrice = (item.Price * order.Quantity) }).GroupBy(c => c.OrderDate.Month).SelectMany(d => d).ToList().OrderByDescending(e => e.OrderDate).ToList().ForEach(f => { Console.WriteLine(f.OrderId + " | " + f.ItemName + " | " + f.OrderDate + " | " + f.TotalPrice); });

            //7.
            //Console.WriteLine("\nOrders with quantities > 0: ");
            //orderCollection.Where(a => a.Quantity > 0).ToList().ForEach(a => { Console.WriteLine(a.OrderId + " | " + a.ItemName + " | " + a.OrderDate + " | " + a.Quantity); });

            //var largeQntyItem = orderCollection.OrderByDescending(a => a.Quantity).First().ItemName;
            //Console.WriteLine("\nLarge quantity in single order: " + largeQntyItem);

            //Console.WriteLine("\nOrders placed before Jan 2019 > 0: ");
            //orderCollection.Where(a => a.OrderDate.Year < DateTime.Now.Year).ToList().ForEach(a => { Console.WriteLine(a.OrderId + " | " + a.ItemName + " | " + a.OrderDate + " | " + a.Quantity); });

            //8.

            //var lgeQtyItm = (from o in orderCollection
            //                 orderby o.Quantity descending
            //                 select o.ItemName).First();

            //Console.WriteLine("\nLarge quantity in single order: " + lgeQtyItm);

            //var orderResult  = from o in orderCollection
            //             where o.OrderDate.Year < DateTime.Now.Year
            //             select o;
            //Console.WriteLine("\nOrders placed before Jan 2019 > 0: ");
            //orderResult.ToList().ForEach(a => { Console.WriteLine(a.OrderId + " | " + a.ItemName + " | " + a.OrderDate + " | " + a.Quantity); });

            //9.
            var evenArray = intArray.Where(a => a % 2 == 0).ToArray();
            Console.WriteLine("\nCount of elements in Array: " + intArray.Count());
            Console.WriteLine("\nEven Array: " + string.Join(" ", evenArray));

            List<Order> orderCollection = new List<Order>
            {
                new Order{ OrderId=1, ItemName="Mobile", OrderDate= DateTime.Parse("01-08-2010"), Quantity=10},
                new Order{ OrderId=2, ItemName="TV", OrderDate= DateTime.Parse("05-09-2016"), Quantity=45},
                new Order{ OrderId=3, ItemName="Car", OrderDate= DateTime.Parse("01-01-2000"), Quantity=30},
                new Order{ OrderId=4, ItemName="Laptop", OrderDate= DateTime.Parse("07-10-2015"), Quantity=13},
                new Order{ OrderId=5, ItemName="AC", OrderDate= DateTime.Parse("02-07-2013"), Quantity=80},
                new Order{ OrderId=6, ItemName="Modem", OrderDate= DateTime.Parse("09-05-2018"), Quantity=354},
                new Order{ OrderId=7, ItemName="Mouse", OrderDate= DateTime.Parse("06-02-2019"), Quantity=87},
                new Order{ OrderId=8, ItemName="Keyboard", OrderDate= DateTime.Parse("05-09-2013"), Quantity=321},
                new Order{ OrderId=9, ItemName="Mobile", OrderDate= DateTime.Parse("01-08-2010"), Quantity=43},
                new Order{ OrderId=10, ItemName="TV", OrderDate= DateTime.Parse("05-09-2016"), Quantity=56},
                new Order{ OrderId=11, ItemName="Car", OrderDate= DateTime.Parse("01-01-2000"), Quantity=23},
                new Order{ OrderId=12, ItemName="Laptop", OrderDate= DateTime.Parse("07-10-2015"), Quantity=21},
                new Order{ OrderId=13, ItemName="AC", OrderDate= DateTime.Parse("02-07-2013"), Quantity=76},
                new Order{ OrderId=14, ItemName="Modem", OrderDate= DateTime.Parse("09-05-2018"), Quantity=87}
            };

            Console.WriteLine("\nInput:");
            orderCollection.ForEach(a => { Console.WriteLine(a.OrderId + " | " + a.ItemName + " | " + a.OrderDate + " | " + a.Quantity); });

            var sumByItem = orderCollection.GroupBy(a => a.ItemName).Select(b => new { b.Key, Sum = b.Sum(c => c.Quantity) }).ToList();

            Console.WriteLine("\nSum of Quantities:");
            sumByItem.ForEach(a => { Console.WriteLine(a.Key + " | " + a.Sum); });

            Console.WriteLine("\nItem with Max Quantity: " + sumByItem.OrderByDescending(a => a.Sum).First().Key);

            Console.ReadKey();
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; } 
    }
    public class Item
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
}
