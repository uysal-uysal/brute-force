using System;

namespace brute_force
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write to text: ");
            string text = Console.ReadLine();

            app1 q1= new app1();
            //firstApp.Directory = "";
            //firstApp.FileName = "şifreler";
            q1.Run(text);

            app2 q2 = new app2();
            //secondApp.Directory = "ANA DİZİN";
            //secondApp.FileName = "şifreler2";
            q2.Run();
        }
    }
}
