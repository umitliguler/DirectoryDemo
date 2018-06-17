using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory("c:\\vidobu\\test1");
            Console.WriteLine(Directory.GetCreationTime("c:\\vidobu\\test1"));

            Directory.CreateDirectory("c:\\vidobu\\test2");
            Console.WriteLine(Directory.GetCreationTime("c:\\vidobu\\test2"));

            Directory.Move("c:\\vidobu\\test1", "c:\\vidobu\\test2\\test15");

            //if (Directory.Exists("c:\\vidobu\\test1"))
            //{
            //    Directory.Delete("c:\\vidobu\\test1"); 
            //}

            Console.ReadKey();
        }
    }
}
