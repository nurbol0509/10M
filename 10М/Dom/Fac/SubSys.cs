using System;

public class TV
{
    public void TurnOn()
    {
        Console.WriteLine("Телевизор включен.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Телевизор выключен.");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine($"Канал телевизора установлен на {channel}.");
    }

    public void SetAudioInput()
    {
        Console.WriteLine("Аудиовход телевизора установлен на внешнюю аудиосистему.");
    }
}

public class AudioSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Аудиосистема включена.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Аудиосистема выключена.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Громкость аудиосистемы установлена на уровень {level}.");
    }
}


public class DVDPlayer
{
    public void Play()
    {
        Console.WriteLine("DVD-проигрыватель воспроизводит диск.");
    }

    public void Pause()
    {
        Console.WriteLine("DVD-проигрыватель на паузе.");
    }

    public void Stop()
    {
        Console.WriteLine("DVD-проигрыватель остановлен.");
    }

    public void TurnOn()
    {
        Console.WriteLine("DVD-проигрыватель включен.");
    }

    public void TurnOff()
    {
        Console.WriteLine("DVD-проигрыватель выключен.");
    }
}


public class GameConsole
{
    public void TurnOn()
    {
        Console.WriteLine("Игровая консоль включена.");
    }

    public void StartGame()
    {
        Console.WriteLine("Игра на консоли запущена.");
    }
}
