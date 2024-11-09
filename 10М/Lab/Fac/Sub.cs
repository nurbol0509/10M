using System;

public class AudioSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Audio system is turned on.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Audio volume is set to {level}.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Audio system is turned off.");
    }
}

public class VideoProjector
{
    public void TurnOn()
    {
        Console.WriteLine("Video projector is turned on.");
    }

    public void SetResolution(string resolution)
    {
        Console.WriteLine($"Video resolution is set to {resolution}.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Video projector is turned off.");
    }
}

public class LightingSystem
{
    public void TurnOn()
    {
        Console.WriteLine("Lights are turned on.");
    }

    public void SetBrightness(int level)
    {
        Console.WriteLine($"Lights brightness is set to {level}.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Lights are turned off.");
    }
}


