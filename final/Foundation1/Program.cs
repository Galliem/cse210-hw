using System;
namespace foundation1;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        System.Console.WriteLine("Let's input some video information");
        Video videoAction = new Video();
        videoAction.getVideo1();
        videoAction.getVideo2();
        videoAction.getVideo3();
    }
}