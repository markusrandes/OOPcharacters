
using System;

namespace OOPsuperheros
{
    class Program
    {
        class Player
        {
            string name;
            int hp;
            private string _name;

            public Player (string name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }

            public void SayHello()
            {
                Console.WriteLine($"{name} says Hello!");
            }
            public void ShowYourHP()
            {
                Console.WriteLine($"{name}`s HP: {hp}");
            }
             
            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }

            public void TakeDamage(int damage)
            {
                if (hp <= 0)
                {
                    hp = 0;
                    {
                    }
                    
                }

            }

            public int HP
            {
                get { return hp; }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("name your first character:");
            Console.WriteLine("name your second character:");
            string characterNameone = Console.ReadLine();
            string characterNametwo = Console.ReadLine();



            Player playerone = new Player(characterNameone);
            Player plyertwo = new Player(characterNametwo);
            playerone.SayHello();
            playerone.ShowYourHP();
            playertwo.SayHello();
            Playertwo.ShowYourHP();
            for(int i=0; i< 3; i++)
            {
                playerone.TakeDamage(Playertwo.Makedamage());
                playertwo.takeDamage(playerone.MakeDamage());
                playerone.ShowYourHP();
                playertwo.ShowYourHP();
            }

            if(playerone.HP > playertwo.HP)
            {
                Console.WriteLine("player one won!");
            }else if (playerone.HP < playertwo.HP)
            {
                Console.WriteLine("player two won!");
            }  else
            {
                Console.WriteLine("it`s a tie");
            }


            Console.WriteLine($"Player one hit{playerone.MakeDamage()}");
        }
    }
}
