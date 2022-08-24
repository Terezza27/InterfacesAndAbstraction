using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer>
                 buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                if (cmd.Length == 4)
                {
                    Citizen citizen = new Citizen(cmd[0], int.Parse(cmd[1]), cmd[2], cmd[3]);
                    buyers.Add(citizen);
                }
                else if (cmd.Length == 3)
                {
                    Rebel rebel = new Rebel(cmd[0], int.Parse(cmd[1]), cmd[2]);
                    buyers.Add(rebel);
                }
            }

            while (true)
            {
                string cmdName = Console.ReadLine();

                if (cmdName == "End")
                {
                    break;
                }
                foreach (var buyer in buyers)
                {
                    if (buyer.Name == cmdName)
                    {
                        buyer.BuyFood();
                    }
                }
            }
            int food = 0;
            foreach (var buyer in buyers)
            {
                food += buyer.Food;
            }
            Console.WriteLine(food);































            //List<Citizen> citizens = new List<Citizen>();

            //List<Robot> robots = new List<Robot>();

            //List<IIdentifiable> identifiables = new List<IIdentifiable>();

            //List<IBirthdateable> birthdateables = new List<IBirthdateable>();

            //while (true)
            //{

            //    string[] cmd = Console.ReadLine().Split();

            //    if (cmd[0] == "End")
            //    {
            //        break;
            //    }

            //    if (cmd[0] == "Citizen")
            //    {
            //        Citizen citizen = new Citizen(cmd[1], int.Parse(cmd[2]), cmd[3], cmd[4]);
            //        //identifiables.Add(citizen);
            //        birthdateables.Add(citizen);
            //    }
            //    else if (cmd[0] == "Pet")
            //    {
            //        Pet pet = new Pet(cmd[1], cmd[2]);
            //        birthdateables.Add(pet);
            //    }
            //    //else
            //    //{
            //    //    Robot robot = new Robot(cmd[0], cmd[1]);
            //    //    //identifiables.Add(robot);
            //    //}

            //}

            //string lastNums = Console.ReadLine();
            //foreach (var item in birthdateables)
            //{
            //    if (item.Birthdate.EndsWith(lastNums))
            //    {
            //        Console.WriteLine(item.Birthdate);
            //    }
            //}

            ////string lastNums = Console.ReadLine();
            ////foreach (var item in identifiables)
            ////{
            ////    if (item.Id.EndsWith(lastNums))
            ////    {
            ////        Console.WriteLine(item.Id);
            ////    }
            ////}



        }
    }
}