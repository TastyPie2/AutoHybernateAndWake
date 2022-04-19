using DK.WshRuntime;
using TastyIO;

public static class Program
{

    static void Main()
    {
        try
        {
            string destination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "AutoHybernateAndWake");
            string source = Path.Combine(Environment.CurrentDirectory, "AutoHybernateAndWake");

            Directory.CreateDirectory(destination);

            Console.WriteLine("Moving files...");

            string[] files = Directory.GetFiles(source);
            Parallel.For(0, files.Length, i => 
            {
                File.Copy(files[i], Path.Combine(destination, files[i].Split("\\").Last()), true);
            });

            Console.WriteLine("Creating shortcut...");
            WshInterop.CreateShortcut(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "AutoHybernateAndWake.lnk"), "", Path.Combine(destination, "AutoHybernateAndWake.exe"), "", Path.Combine(destination, "Icon.ico"));

            Console.WriteLine("Done!");
            Console.Read();
        }
        catch (Exception ex)
        { 
            Console.WriteLine(ex.ToString());
            Console.Read();
        }
    }
}