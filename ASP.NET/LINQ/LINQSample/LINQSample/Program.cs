using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //參考https://ithelp.ithome.com.tw/articles/10255735

            //var students = new List<Student>();
            //var students = new List<Student>
            //                    {
            //                        new Student { Age = 16, Gender = CommonEnum.Gender.Female, LastName = "Kuo", FirstName = "Sarah" },
            //                        new Student { Age = 4, Gender = CommonEnum.Gender.Male, LastName = "Kuo", FirstName = "Sammy" },
            //                        new Student { Age = 22, Gender = CommonEnum.Gender.Female, LastName = "Kuo", FirstName = "Emily" },
            //                        new Student { Age = 32, Gender = CommonEnum.Gender.Male, LastName = "Li", FirstName = "Ray" },
            //                        new Student { Age = 52, Gender = CommonEnum.Gender.Female, LastName = "Kuo", FirstName = "Ray" },
            //                    };
            //foreach (var s in students)
            //{
            //    Console.WriteLine(s.FirstName + "\t" + s.LastName + "\t" + s.Age + "\t" + s.Gender);
            //}

            //Console.WriteLine("==========Lambda 運算式 Case 1-1: Where==========");
            
            ////Case 1: Where
            //var result = students.Where(s => s.Age == 16 && s.Gender == CommonEnum.Gender.Female).ToList();
            //foreach(var r in result)
            //{
                
            //    Console.WriteLine(r.FirstName + "\t" + r.LastName + "\t" + r.Age + "\t" + r.Gender );
            //}

            //Console.WriteLine("==========Lambda 運算式 Case 1-2: Where filter with input==========");

            ////Case 2: filter with input
            //var queryInput = new QueryInput();
            //queryInput.FirstName = "Ray";
            ////queryInput.LastName = "Li";
            //queryInput.Age = 32;

            //var filterResult = students;
            //if (!string.IsNullOrWhiteSpace(queryInput.FirstName))
            //{
            //    filterResult = filterResult.Where(s => s.FirstName == queryInput.FirstName).ToList();
            //}
            //if (!string.IsNullOrWhiteSpace(queryInput.LastName))
            //{
            //    filterResult = filterResult.Where(s => s.LastName == queryInput.LastName).ToList();
            //}
            //if (queryInput.Age.HasValue)
            //{
            //    filterResult = filterResult.Where(s => s.Age == queryInput.Age).ToList();
            //}
            //if (queryInput.Gender.HasValue)
            //{
            //    filterResult = filterResult.Where(s => s.Gender == queryInput.Gender).ToList();
            //}

            //foreach (var filter in filterResult)
            //{
            //    Console.WriteLine(filter.FirstName + "\t" + filter.LastName + "\t" + filter.Age + "\t" + filter.Gender);
            //}

            //Console.WriteLine("==========Lambda 運算式 Case 1-3: execute ToList() in the final==========");
            ////Case 3: execute ToList() in the final
            ////改寫成最後一句在ToList(),只有當執行ToList()才真正查詢
            //var query = students.AsEnumerable(); //AsEnumerable

            //if (!string.IsNullOrWhiteSpace(queryInput.FirstName))
            //{
            //    query = query.Where(s => s.FirstName == queryInput.FirstName);
            //}
            //if (!string.IsNullOrWhiteSpace(queryInput.LastName))
            //{
            //    query = query.Where(s => s.LastName == queryInput.LastName);
            //}
            //if (queryInput.Age.HasValue)
            //{
            //    query = query.Where(s => s.Age == queryInput.Age);
            //}
            //if (queryInput.Gender.HasValue)
            //{
            //    query = query.Where(s => s.Gender == queryInput.Gender);
            //}

            //filterResult = query.ToList(); //ToList()

            //foreach (var filter in filterResult)
            //{
            //    Console.WriteLine(filter.FirstName + "\t" + filter.LastName + "\t" + filter.Age + "\t" + filter.Gender);
            //}

            //Console.WriteLine("==========Lambda 運算式 Case 2: Select==========");
            ////Where是條件, Select是要取哪個item
            ////Case 2.1
            //string[] words = { "Hello", "world", "LINQ", "C#", "ASP.NET" };
            //var ws = words.Where(x => x.Length <= 5).Select(x=>x);
            //foreach(var w in ws)
            //{
            //    Console.WriteLine(w);
            //}

            ////Case 2.2
            //filterResult = students.Where(s => s.Age > 18).Select(s => s).ToList();
            //foreach (var fr in filterResult)
            //{
            //    Console.WriteLine(fr.FirstName + "\t" + fr.LastName + "\t" + fr.Age + "\t" + fr.Gender);
            //}

            //Console.WriteLine("============================型別=================================");

            //int i = 1;
            //Console.WriteLine(i.GetType());

            //string str = string.Empty;
            //Console.WriteLine(str.GetType());

            //Console.WriteLine(students.GetType());

            //var obj = new { };
            //Console.WriteLine(obj.GetType());
            

            Console.WriteLine("============================Lambda 運算式: 匿名型別============================");
            //https://ithelp.ithome.com.tw/articles/10100998

            //var obj2 = new { Name = "Leo" };
            //obj2.Name = "Ray"; //匿名型別之屬性是readonly

            var s1 = new Student() { FirstName = "Leo", Age = 40, Gender = CommonEnum.Gender.Female };
            var s2 = new { FirstName = "Leo", Age = 40 };
            var s3 = new { s1.FirstName, s1.Age };

            //Console.WriteLine(s1.FirstName + "\t" + s1.LastName + "\t" + s1.Age + "\t" + s1.Gender);
            //Console.WriteLine(s2.FirstName + "\t" + s2.LastName + "\t" + s2.Age + "\t" + s1.Gender);
            //Console.WriteLine(s3.FirstName + "\t" + s3.LastName + "\t" + s3.Age + "\t" + s3.Gender);

            Console.WriteLine(s1.GetType());
            Console.WriteLine(s2.GetType());
            Console.WriteLine(s3.GetType());

            var s4 = new { Name = "Rose", Score = 60 };
            var s5 = new { s4.Name, s4.Score };
            var s6 = new { s4.Score, s4.Name };

            Console.WriteLine(s4.GetType());
            Console.WriteLine(s5.GetType());
            Console.WriteLine(s6.GetType());

            Console.WriteLine("============================Lambda 運算式: 查詢運算式============================");
            var customers = new[] {
                new { Name = "小李", Discount = 5.0 },
                new { Name = "老王", Discount = 3.0 },
                new { Name = "阿華", Discount = 4.5 },
                new { Name = "明明", Discount = 4.0 }
            };

            //用Select選擇item,此例為Name
            var queryCustomers = customers.Where(c => c.Discount > 3).OrderBy(c => c.Discount).Select(x => x).ToArray();
            foreach (var c in queryCustomers)
            {
                Console.WriteLine(c.Name + "\t" + c.Discount);
            }

            var queryCustomers1 = customers.Where(c => c.Discount > 3).OrderBy(c => c.Discount).Select(x => x.Name).ToArray();
            foreach (var c in queryCustomers1)
            {
                Console.WriteLine(c);
            }

            //https://dotblogs.com.tw/DavidTalk/2018/05/25/233336
            //lambda Select多欄位
            //用Select選擇item,此例為Name並產生新的欄位Perc
            var queryCustomers2 = customers.Where(c => c.Discount > 3).OrderBy(c => c.Discount).Select(c => new { c.Name, Perc = c.Discount/100}).ToArray(); 
            foreach (var c in queryCustomers2)
            {
                Console.WriteLine(c.Name + "\t" + c.Perc);
            }

            Console.WriteLine("============================我是IMES=================================");

            string shipmentNo = "0103266810";
            IList<ShipmentDeliveryPalletInfo> dpInfoList = new List<ShipmentDeliveryPalletInfo>
            {
                //('0103266809','0103266810','0103266811')
                //0327384586','0327384523','0327384524','0327384525'
                new ShipmentDeliveryPalletInfo { ShipmentNo = "0103266809", PalletNo = "0327384586" },
                new ShipmentDeliveryPalletInfo { ShipmentNo = "0103266810", PalletNo = "0327384523" },
                new ShipmentDeliveryPalletInfo { ShipmentNo = "0103266810", PalletNo = "0327384524" },
                new ShipmentDeliveryPalletInfo { ShipmentNo = "0103266811", PalletNo = "0327384525" },
            };

            Console.WriteLine("ShipmentNo\tPalletNo");

            foreach (var dpInfo in dpInfoList)
            {
                Console.WriteLine(dpInfo.ShipmentNo + "\t" + dpInfo.PalletNo);
            }

            Console.WriteLine("============================我是分隔線=================================");

            var filters = dpInfoList.Where(x => x.ShipmentNo != shipmentNo).ToList();
            foreach (var filter in filters)
            {
                Console.WriteLine(filter.ShipmentNo + "\t" + filter.PalletNo);
            }

            Console.WriteLine("============================我是分隔線=================================");

            Console.ReadKey();
        }
    }

}
