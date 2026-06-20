using System;
using System.Buffers;

namespace YUML;

class Program
{
    public static void Main(string[] args)
    {
        Render();
    }

    
    public byte[] pixels = { 0, 0, 4, 0, 0, 4 };
    private static string outputpath = "/ConsoleApp1/output/";

    // 1. oh a slash, i wonder what that's used for
    public static char slash = '/';
    public static string Unicode_Backslash = new string(Unicode_Backslash.Where(c => char.IsControl(c)).ToArray());
    public static string output()
    {
        // i could swear im getting somewhere lmao
        string internaloutput = $"image_{DateTime.Today}.png";


        // 1.1 found it

        // on a side note who and why did they put 2 foreach loops, oh wait its me. Bruh
        if (internaloutput.Contains(slash))
        {
            // i guess i gotta split the whole string just to get /
            string[] _slash = internaloutput.Split('/');
            foreach (string Slash in _slash)
            {
                if (Slash.Contains('/')) Slash.Replace(slash, '/');
            }
            // ah yes converting
            char[] _backslashs = Unicode_Backslash.ToCharArray();


            foreach (char Backslash in _backslashs)
            {
                // what am i finding the galaxy?
                char b = Backslash;
                b.ToString().Replace(Backslash, '_');
            }
        }
        // yes
        return internaloutput;
    }
    // ah yes lets assign the CreatePath to Directory and ADD IT TO DIRECTORYINFO
    public static DirectoryInfo createpath = Directory.CreateDirectory(outputpath);

    // i can already tell this isn't gonna look pretty
    public static string ConnectedPath = createpath + output();

    // Rendering... yo momma
    public static void Render()
    {
        if (!File.Exists(ConnectedPath))
        {
            Directory.CreateDirectory(outputpath);
            File.Create(output());
        }
        else
        {
            // we can't even get here yet, the hell you mean "could not write file"!?
            throw new Exception("Could not write file");
        }
    }
}

