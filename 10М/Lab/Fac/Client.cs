using System;


class Program
{
    static void Main(string[] args)
    {
        AudioSystem audio = new AudioSystem();
        VideoProjector video = new VideoProjector();
        LightingSystem lights = new LightingSystem();

        HomeTheaterFacade homeTheater = new HomeTheaterFacade(audio, video, lights);

        homeTheater.StartMovie();

        Console.WriteLine();

        homeTheater.EndMovie();
    }
}
