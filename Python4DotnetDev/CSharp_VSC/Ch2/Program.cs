using System;
using static System.Console;
namespace Ch2
{
    class Program
    {
        static void DemoPrintGreeting()
        {
            Console.WriteLine("Hello World!");
        }

        static void DemoLocalVariable()
        {
            var aVariable = "7";
            aVariable = "The name is 007";
            WriteLine(aVariable);
        }

        static string name="Unknown";

        static void DemoGlobalVariable()
        {
            name="Paul";
            WriteLine(name+"y");   

        }

        static void DemoFunctionParams(string first,string last)
        {
            WriteLine("The name is "+first+" "+last);
        }
        static string DemoFunctionReturn(string first, string last)
        {
            string fullName = first+" "+last;
            return "The full name is "+fullName;
        }

        static string DemoFunctionDefault(string first="Someone",string last="Unknown")
        {
                string fullName = first+" "+last;
                return "The full name is "+fullName;
        }

        static void DemoArithmetic(){
            WriteLine("\nDemo Arithmetic\n");
            WriteLine("7+2={0}",7+2);
            WriteLine("7-2={0}",7-2);
            WriteLine("7*2={0}",7*2);
            WriteLine("7/2={0}",(decimal)7/(decimal)2);
            WriteLine("7%2={0}",7%2);
            WriteLine("Math.Pow(7,2)={0}",Math.Pow(7,2));
            WriteLine("Math.Floor(decimal.Divide(7,2))={0}",Math.Floor((decimal)7/(decimal)2));
            WriteLine("Math.Ceiling(decimal.Divide(7,2))={0}",Math.Ceiling((decimal)7/(decimal)2));
        }

        static void DemoFunctionCalls()
        {
            DemoFunctionParams("James","Bond");
            WriteLine(DemoFunctionReturn("James","Bond"));
            WriteLine(DemoFunctionDefault(last:"Bond"));
        }
        static void Main(string[] args)
        {
            //DemoPrintGreeting();
            //DemoLocalVariable();
            //DemoGlobalVariable();WriteLine(name);
            //DemoArithmetic();
            DemoFunctionCalls();
        }
    }
}
