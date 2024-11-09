using System;

public class HomeTheaterFacade
{
    private TV _tv;
    private AudioSystem _audioSystem;
    private DVDPlayer _dvdPlayer;
    private GameConsole _gameConsole;

    public HomeTheaterFacade(TV tv, AudioSystem audioSystem, DVDPlayer dvdPlayer, GameConsole gameConsole)
    {
        _tv = tv;
        _audioSystem = audioSystem;
        _dvdPlayer = dvdPlayer;
        _gameConsole = gameConsole;
    }

    public void WatchMovie()
    {
        Console.WriteLine("Подготовка к просмотру фильма...");
        _tv.TurnOn();
        _audioSystem.TurnOn();
        _audioSystem.SetVolume(10);
        _dvdPlayer.TurnOn();
        _dvdPlayer.Play();
        Console.WriteLine("Фильм начался.");
    }

    public void EndMovie()
    {
        Console.WriteLine("Выключение системы после фильма...");
        _dvdPlayer.Stop();
        _dvdPlayer.TurnOff();
        _audioSystem.TurnOff();
        _tv.TurnOff();
        Console.WriteLine("Фильм окончен.");
    }

    public void StartGame()
    {
        Console.WriteLine("Подготовка к запуску игры...");
        _tv.TurnOn();
        _audioSystem.TurnOn();
        _audioSystem.SetVolume(8);
        _gameConsole.TurnOn();
        _gameConsole.StartGame();
        Console.WriteLine("Игра запущена.");
    }

    public void ListenToMusic()
    {
        Console.WriteLine("Подготовка к прослушиванию музыки...");
        _tv.TurnOn();
        _tv.SetAudioInput();
        _audioSystem.TurnOn();
        _audioSystem.SetVolume(7);
        Console.WriteLine("Музыка играет.");
    }

    public void SetVolume(int level)
    {
        _audioSystem.SetVolume(level);
        Console.WriteLine($"Громкость установлена на {level}.");
    }
}

