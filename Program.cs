using System;
using System.Xml.Serialization;
Import DataMahasiswa103022300064;
Import TeamMember103022300064;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300064 dM = new DataMahasiswa103022300064();
        dM.readJSON();
       TeamMember103022300064 tM = new TeamMember103022300064();
        tM.readJSON();
    }
}