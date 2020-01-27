using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Player(string name, int age)
        {
            Name = name;
            Age = age; 
        }
    }
    class Team : IEnumerable
    {
        private Player[] playerArray = new Player[4]; 

        public Team()
        {
            playerArray[0] = new Player("Virat", 28);
            playerArray[1] = new Player("Dhoni", 35);
            playerArray[2] = new Player("Rohit", 29);
            playerArray[0] = new Player("Yuvaraj", 34);
        }

        public IEnumerator GetEnumerator()
        {
            return playerArray.GetEnumerator();
        }
    }
    class IEnumerable
    {
        static void Main(string[] args)
        {
            Team obj = new Team();

            foreach(Player player in obj)
            {
                Console.WriteLine("Name is {0} and Age is {1}", player.Name, player.Age);
            }
        }
    }
}
 