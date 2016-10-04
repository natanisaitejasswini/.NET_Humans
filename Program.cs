using System;

namespace ConsoleApplication
{
    public class Human
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string n_val)
        {
            name = n_val;
        }
        public Human(string n_val, int s_val, int i_val, int d_val, int h_val)
        {
            name = n_val;
            strength = s_val;
            intelligence = i_val;
            dexterity = d_val;
            health = h_val;
        }
        // Attack Method
        public void Attack(Human opponent) 
        {
            opponent.health -= 5*opponent.strength;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Human character = new Human("Teju", 12, 45, 10, 100); 
            Console.WriteLine($"my character name is {character.name}, it's strength {character.strength}, intelligence {character.intelligence}, dexterity {character.dexterity} and health is {character.health}");
            Human enemy = new Human("Karthik", 10, 45, 10, 100); 
            character.Attack(enemy);
            Console.WriteLine($"my enemy name is {enemy.name}, it's strength {enemy.strength}, intelligence {enemy.intelligence}, dexterity {enemy.dexterity} and health is {enemy.health}");

        }
    }
}
