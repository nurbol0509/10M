using System;

public class HomeTheaterFacade
{
    private AudioSystem _audioSystem;
    private VideoProjector _videoProjector;
    private LightingSystem _lightingSystem;

    public HomeTheaterFacade(AudioSystem audioSystem, VideoProjector videoProjector, LightingSystem lightingSystem)
    {
        _audioSystem = audioSystem;
        _videoProjector = videoProjector;
        _lightingSystem = lightingSystem;
    }

    public void StartMovie()
    {
        Console.WriteLine("Preparing to start the movie...");
        _lightingSystem.TurnOn();
        _lightingSystem.SetBrightness(5);
        _audioSystem.TurnOn();
        _audioSystem.SetVolume(8);
        _videoProjector.TurnOn();
        _videoProjector.SetResolution("HD");
        Console.WriteLine("Movie started.");
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down movie...");
        _videoProjector.TurnOff();
        _audioSystem.TurnOff();
        _lightingSystem.TurnOff();
        Console.WriteLine("Movie ended.");
    }
}
