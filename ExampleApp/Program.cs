using System;
using System.IO;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string UNC_SHARED_FILE = @"\\127.0.0.1\Share 1\Test.txt";
            const string UNC_SHARED_SUB_FOLDER = @"\\127.0.0.1\Share 1\Test Sub Folder";
            const string UNC_SHARED_ROOT_FOLDER = @"\\127.0.0.1\Share 1";
            const string UNC_SHARED_ROOT_FILE = @"\\127.0.0.1\Test.txt";
            
            const string SHARED_FILE = @"C:\Share 1\Test.txt";
            const string SHARED_SUB_FOLDER = @"C:\Share 1\Test Sub Folder";
            const string SHARED_ROOT_FOLDER = @"C:\Share 1";
            const string SHARED_ROOT_FILE = @"C:\Test.txt";
            
            //UNC
            Console.WriteLine("Below are examples of UNC Path processing using Path.GetFileName");
            Console.WriteLine("---------------------------------------------------------------");
            
            Console.WriteLine($"1.0 Testing Sub File: \"{UNC_SHARED_FILE}\"");
            Console.WriteLine($"Output: {Path.GetFileName(UNC_SHARED_FILE)}\r\n");

            Console.WriteLine($"2.0 Testing Sub Folder: \"{UNC_SHARED_SUB_FOLDER}\"");
            Console.WriteLine($"Output: {Path.GetFileName(UNC_SHARED_SUB_FOLDER)}\r\n");

            Console.WriteLine($"3.0 Testing Root Folder: \"{UNC_SHARED_ROOT_FOLDER}\"");
            Console.WriteLine($"Output: {Path.GetFileName(UNC_SHARED_ROOT_FOLDER)}\r\n");

            Console.WriteLine($"4.0 Testing Root File: \"{UNC_SHARED_ROOT_FILE}\"");
            Console.WriteLine($"Output: {Path.GetFileName(UNC_SHARED_ROOT_FILE)}\r\n");

            //System Paths
            Console.WriteLine("Below are examples of Normal System Path processing using Path.GetFileName");
            Console.WriteLine("---------------------------------------------------------------");
            
            Console.WriteLine($"1.1 Testing Sub File: \"{SHARED_FILE}\"");
            Console.WriteLine($"Output: {Path.GetFileName(SHARED_FILE)}\r\n");

            Console.WriteLine($"2.1 Testing Sub Folder: \"{SHARED_SUB_FOLDER}\"");
            Console.WriteLine($"Output: {Path.GetFileName(SHARED_SUB_FOLDER)}\r\n");

            Console.WriteLine($"3.1 Testing Root Folder: \"{SHARED_ROOT_FOLDER}\"");
            Console.WriteLine($"Output: {Path.GetFileName(SHARED_ROOT_FOLDER)}\r\n");

            Console.WriteLine($"4.1 Testing Root File: \"{SHARED_ROOT_FILE}");
            Console.WriteLine($"Output: {Path.GetFileName(SHARED_ROOT_FILE)}\r\n");
        }
    }
}
