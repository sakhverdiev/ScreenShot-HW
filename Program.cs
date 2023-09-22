class Bitmap
{
    private int v1;
    private int v2;

    public Bitmap(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public object Size { get; internal set; }

    internal void Save(string fileName)
    {
        throw new NotImplementedException();
    }
}

class Graphics
{
    internal static Graphics FromImage(Bitmap png)
    {
        throw new NotImplementedException();
    }

    internal void CopyFromScreen(int v1, int v2, int v3, int v4, object size)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main()
    {
        ConsoleKeyInfo key;
        bool start = true;
        while (start)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter => Screen");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Escape => Exit");
            Console.ForegroundColor = ConsoleColor.White;
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                if (!Directory.Exists(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Image"))
                    Directory.CreateDirectory(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\image1");

                Bitmap png = new Bitmap(1080, 900);
                Graphics g = Graphics.FromImage(png);
                g.CopyFromScreen(0, 0, 0, 0, size: png.Size);
                Guid i = Guid.NewGuid();
                string fileName = string.Format($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Image1" + @$"\Image  {i}" + ".png");
                png.Save(fileName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESFULL");
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                start = false;
                Environment.Exit(0);
            }

            else
            {
                Console.Clear();
                start = true;
            }
        }
    }
}