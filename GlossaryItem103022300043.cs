using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static jurnalmod07.TeamMembers103022300043;

namespace jurnalmod07
{
    public class GlossaryItem103022300043
    {
        public class dataGloss
        {
            public glossary glossary { get; set; }
        }

        public class glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef Glossdef { get; set; }
            public string GlossSee { get; set; }

        }

        public class GlossDef
        {
            public string para { get; set; }
            public string GlossSeeAlso { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Coding\\Kuliah\\KPL\\JURNAL_MOD_07\\jurnal7_3_103022300043.json");
            dataGloss data = JsonSerializer.Deserialize<dataGloss>(json);

            Console.WriteLine($"ID: {data.glossary.GlossDiv.GlossList.GlossEntry.ID}");
            Console.WriteLine($"SortAs: {data.glossary.GlossDiv.GlossList.GlossEntry.SortAs}");
            Console.WriteLine($"GlossTerm: {data.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm}");
            Console.WriteLine($"Acronym: {data.glossary.GlossDiv.GlossList.GlossEntry.Acronym}");
            Console.WriteLine($"Abbrev: {data.glossary.GlossDiv.GlossList.GlossEntry.Abbrev}");
        }
    }
}
