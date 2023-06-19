//Реализовать базу данных игроков и методы для работы с ней.
//У игрока может быть уникальный номер, ник, уровень, флаг – забанен ли он(флаг - bool).
//Реализовать возможность добавления игрока, бана игрока по уникальный номеру, разбана игрока по уникальный номеру и удаление игрока.
//Создание самой БД не требуется, задание выполняется инструментами, 
//которые вы уже изучили в рамках курса. Но нужен класс, который содержит игроков и её можно назвать "База данных".
using System;

namespace DataBasePlayer
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class DataBase
    {
        private List<Player> _dataBases = new List<Player>();

        public void CreateNewPlayer(Player player)
        {
            string userInputNamePlayer = "";
            int userInputLevelPlayer;
            int minimumLengthNamePlayer = 1;
            int minimumLevelPlayer = 1;
            int maximumLevelPlayer = 100;

            Console.Clear();
            Console.WriteLine($"Введите ник персонажа");
            userInputNamePlayer = Console.ReadLine();

            while (userInputNamePlayer.Length < minimumLengthNamePlayer)
            {
                Console.Clear();
                Console.Write("Поле логина не может быть пустым. Введите ник персонажа: ");
                userInputNamePlayer = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine($"Введите уровень персонажа. Он не должен быть ниже {minimumLevelPlayer} и {minimumLevelPlayer}");
            userInputLevelPlayer = Convert.ToInt32(Console.ReadLine());

            while (userInputLevelPlayer < minimumLevelPlayer || userInputLevelPlayer > maximumLevelPlayer)
            {
                Console.Clear();
                Console.Write($"Уровень персонажа не может быть ниже {minimumLevelPlayer} и выше {maximumLevelPlayer}. Введите уровень персонажа: ");
                userInputLevelPlayer = Convert.ToInt32(Console.ReadLine());
            }

            _dataBases.Add(new Player(userInputNamePlayer, userInputLevelPlayer));
        }

        public void ShowPlayer(Player player)
        {
            if (_dataBases.Count < 1)
                Console.WriteLine($"База данных пуста. Добавьте Игроков");
            else
            {
                for (int i = 0; i < _dataBases.Count; i++)
                {
                    Console.WriteLine(_dataBases[i]);
                }
            }

            Console.ReadKey();
        }

        public void BanPlayer(Player player)
        {
            player.Id
        }

    }

    class Player
    {
        private static int _ids;

        public Player(string name, int level)
        {
            Id = ++_ids;
            _name = name;
            _level = level;
            _isBan = false;
        }

        private int Id { get; set; }
        private string _name { get; set; }
        private int _level { get; set; }
        private bool _isBan { get; set; }
    }
}