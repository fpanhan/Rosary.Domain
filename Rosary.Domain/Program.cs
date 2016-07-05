using Rosary.Domain.Chaplets;
using Newtonsoft.Json;
using System;
using System.Globalization;
using Rosary.Domain.Utils;
using System.Reflection;

namespace Rosary.Domain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rosaryOfHailMary = new RosaryOfHailMary(Enum.RosaryPrayType.RosaryOfOurLadyComplete, CultureInfo.CreateSpecificCulture("pt-br")).SetLanguage(CultureInfo.CreateSpecificCulture("pt-br"));
            //var rosaryCompleteSerialized = JsonConvert.SerializeObject(rosaryOfHailMary);
            //var rosaryDeserialized = JsonConvert.DeserializeObject<RosaryOfHailMary>(rosaryCompleteSerialized);
            foreach (var decade in rosaryOfHailMary.Decades)
            {
                Console.WriteLine(decade.Description + "\n");
                foreach (var pray in decade.Prays)
                    Console.WriteLine("--" + pray.Description + "\n");
            }

            var typelist = Extensions.GetTypesInNamespace(Assembly.GetExecutingAssembly(), "Rosary.Domain.Chaplets");
            for (int i = 0; i < typelist.Length; i++)
            {
                Console.WriteLine(typelist[i].Name);
            }


            //var rosaryOfDivineMercy = new RosaryOfDivineMercy(Enum.RosaryPrayType.RosaryOfDivineMercy, CultureInfo.CreateSpecificCulture("pt-br")).SetLanguage(CultureInfo.CreateSpecificCulture("pt-br"));
            //foreach (var decade in rosaryOfDivineMercy.Decades)
            //{
            //    Console.WriteLine(decade.Description + "\n");
            //    foreach (var pray in decade.Prays)
            //    {
            //        Console.WriteLine("--" + pray.Description);
            //    }
            //    Console.WriteLine("\n");
            //}

            Console.ReadKey();
        }
    }
}
