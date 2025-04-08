using System;
using System.IO;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jurnalmod07
{
    public class DataMahasiswa103022300043
    {
        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Kuliah
        {
            public List<MataKuliah> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("C:\\Coding\\Kuliah\\KPL\\JURNAL_MOD_07\\jurnal7_1_103022300043.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);
            Kuliah matkul = JsonSerializer.Deserialize<Kuliah>(json);
            Console.WriteLine($"Nama: {mhs.firstName} {mhs.lastName}");
            Console.WriteLine($"Gender: {mhs.gender}");
            Console.WriteLine($"Usia: {mhs.age}");
            Console.WriteLine($"Alamat: {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
            Console.WriteLine("Courses: ");
            int i = 1;
            foreach (var mk in matkul.courses)
            {
                Console.WriteLine($"MK {i} {mk.code} - {mk.name}");
                i++;
            }
        }
    }
}
