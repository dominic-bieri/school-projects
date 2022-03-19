using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
namespace SuperLeague
{
    public class League
    {

        static void Main(string[] args)
        {
            List<Match> matches = ReadMatches(args[0]);
            Table superLeague = Table.CreateTable(matches);
            Console.WriteLine(superLeague.ToString());
        }

        public static List<Match> ReadMatches(string jsonPath)
        {
            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(json);
                return matches;
            }
        }

    }
}
