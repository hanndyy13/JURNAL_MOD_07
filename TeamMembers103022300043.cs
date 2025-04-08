using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static jurnalmod07.DataMahasiswa103022300043;

namespace jurnalmod07
{
    public class TeamMembers103022300043
    {
        public class Members
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public class Team
        {
            public List<Members> members { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Coding\\Kuliah\\KPL\\JURNAL_MOD_07\\jurnal7_2_103022300043.json");
            Team data = JsonSerializer.Deserialize<Team>(json);

            Console.WriteLine("Team Member List:");
            int i = 1;
            foreach (var mb in data.members)
            {
                Console.WriteLine($"{mb.nim} {mb.firstName} {mb.lastName} {mb.age} {mb.gender}");
                Console.WriteLine("");
                i++;
            }
        }
    }
}
