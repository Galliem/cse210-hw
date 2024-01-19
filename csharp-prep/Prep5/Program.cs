using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        //Functions
        ReturnType FunctionName (paramType paramName1, paramType paramName2){
            Function body
        }

        int Add2(int number){
            return number + 2;
        }
        int more = Add2(10);

        //void wont return anything
        void PrintName(string name) {
            System.Console.WriteLine($"Name is {name}");
        } PrintName("Bob");

        //variable scope    var is only available inside {}
        var y = 0;
        {
            var w = 10;
            w=y+4;
            y=w+5;
        }
    }
}