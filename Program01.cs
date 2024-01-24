using System;
using System.Buffers;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    }

    public int TotalRange(){
        return gallons * milesPerGallon;
    }
    public void Display(){
        System.Console.WriteLine($"{make} {model} {year} {color}: Range = {TotalRange()} miles");
    }
        }