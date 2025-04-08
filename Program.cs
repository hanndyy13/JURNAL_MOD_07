using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DataMahasiswa103022300064
{
    public class Nama
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
    }

    public class address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public address address { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    public static void readJSON()
    {
        string jsonString = File.ReadAllText("C:\\Users\\tupog\\Downloads\\New folder\\JURNAL_MOD_07\\jurnal7_1_103022300064.json");
        Mahasiswa? mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
        CourseList? data = JsonSerializer.Deserialize<CourseList>(jsonString);
        if (mahasiswa != null)
        {
            Console.WriteLine("Nama: " + mahasiswa.nama.firstname + mahasiswa.nama.lastname);
            Console.WriteLine("Umur: " + mahasiswa.nama.age);  
            Console.WriteLine("Alamat: " + mahasiswa.address.street + ", " + mahasiswa.address.city + ", " + mahasiswa.address.state);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int index = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {index} {course.code} - {course.name}");
                index++;
            }
        }
        else
        {
            Console.WriteLine("Gagal melakukan deserialisasi JSON.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300064.readJSON();
    }
}