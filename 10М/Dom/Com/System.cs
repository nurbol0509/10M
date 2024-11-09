using System;
using System.Collections.Generic;

public abstract class FileSystemComponent
{
    public string Name { get; protected set; }

    public FileSystemComponent(string name)
    {
        Name = name;
    }

    public abstract void Display(int depth = 0);

    public abstract int GetSize();
}

public class File : FileSystemComponent
{
    private int _size;

    public File(string name, int size) : base(name)
    {
        _size = size;
    }

    public override void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + $"Файл: {Name}, Размер: {_size} KB");
    }

    public override int GetSize()
    {
        return _size;
    }
}

public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> _components = new List<FileSystemComponent>();

    public Directory(string name) : base(name) { }

    public void AddComponent(FileSystemComponent component)
    {
        if (!_components.Contains(component))
        {
            _components.Add(component);
        }
        else
        {
            Console.WriteLine($"Компонент с именем {component.Name} уже существует в папке {Name}.");
        }
    }

    public void RemoveComponent(FileSystemComponent component)
    {
        if (_components.Contains(component))
        {
            _components.Remove(component);
        }
        else
        {
            Console.WriteLine($"Компонент с именем {component.Name} не найден в папке {Name}.");
        }
    }

    public override void Display(int depth = 0)
    {
        Console.WriteLine(new string('-', depth) + $"Папка: {Name}");

        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }

    public override int GetSize()
    {
        int totalSize = 0;

        foreach (var component in _components)
        {
            totalSize += component.GetSize();
        }

        return totalSize;
    }
}
