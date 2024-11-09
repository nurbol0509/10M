using System;

class Program
{
    static void Main(string[] args)
    {
        TV tv = new TV();
        AudioSystem audioSystem = new AudioSystem();
        DVDPlayer dvdPlayer = new DVDPlayer();
        GameConsole gameConsole = new GameConsole();

        HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, audioSystem, dvdPlayer, gameConsole);

        Console.WriteLine("Сценарий: Просмотр фильма");
        homeTheater.WatchMovie();
        Console.WriteLine();

        Console.WriteLine("Сценарий: Завершение фильма");
        homeTheater.EndMovie();
        Console.WriteLine();

        Console.WriteLine("Сценарий: Запуск игры");
        homeTheater.StartGame();
        Console.WriteLine();

        Console.WriteLine("Сценарий: Прослушивание музыки");
        homeTheater.ListenToMusic();
        Console.WriteLine();

        Console.WriteLine("Сценарий: Регулировка громкости");
        homeTheater.SetVolume(5);
    }
}

