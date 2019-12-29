using System;
using static System.Console;
using System.Collections.Generic;
namespace Ch3
{
    class Program
    {

        static void DemoLists()
        {
            WriteLine("Create, print entire list and just first friend");
            WriteLine("------------------------------------------------");
            List<string> friendList=new List<string>{"Sky","Marcel","Robin","Khaleel","Connie"};
            WriteLine($"All friends = '{friendList[0]}','{friendList[1]}',"+$"'{friendList[2]}','{friendList[3]}',"+$"'{friendList[4]}'");
            
            WriteLine($"First friend = '{friendList[0]}'");

            friendList[0]="Taylor";
            WriteLine($"First friend with name change = '{friendList[0]}'");

            WriteLine($"Partial list of friends = '{friendList[2]}','{friendList[3]}',"+$"'{friendList[4]}'");

            //List of lists
            List<string> familyList=new List<string>{"Mom","Dad","Cousin"};
            List<List<string>> peopleList= new List<List<string>>();
            peopleList.Add(friendList);
            peopleList.Add(familyList);

            WriteLine("\nWrite out peopleList:");
            WriteLine("-------------------------");
            peopleList[0].ForEach(WriteLine);
            peopleList[1].ForEach(WriteLine);
            WriteLine("\nWrite 3rd element from 2nd list:");
            WriteLine("-------------------------------------");
            WriteLine($"Third person in 2nd list is '{peopleList[1][2]}'");


        }
        static void DemoIf()
        {
            int testGrade=95;
            if(testGrade >94)
            {
                WriteLine("You did awesome!!");
            }
            else if(testGrade>85)
            {
                WriteLine("You did good!!");
            }
            else
            {
                WriteLine("You did not work hard!!");
            }

            if((testGrade >=90) && (testGrade<=95))
            {
                WriteLine("You almost reached excellence!!");
            }
        }
        static void Main(string[] args)
        {
            DemoLists();
            //DemoIf();
        }
    }
}
