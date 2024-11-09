using System;

class Program
{
    static void Main(string[] args)
    {
        File file1 = new File("Документ.txt", 100);
        File file2 = new File("Музыка.mp3", 5000);
        File file3 = new File("Фото.jpg", 1500);

        Directory root = new Directory("Корневая папка");
        Directory documents = new Directory("Документы");
        Directory music = new Directory("Музыка");
        Directory photos = new Directory("Фотографии");

        root.AddComponent(documents);
        root.AddComponent(music);
        root.AddComponent(photos);

        documents.AddComponent(file1);
        music.AddComponent(file2);
        photos.AddComponent(file3);

        Console.WriteLine("Структура файловой системы:");
        root.Display();

        Console.WriteLine($"\nОбщий размер файловой системы: {root.GetSize()} KB");

        Console.WriteLine("\nПопытка добавить существующий файл:");
        photos.AddComponent(file3);

        Console.WriteLine("\nПопытка удалить несуществующий файл:");
        photos.RemoveComponent(file1);
    }
}
