namespace SimpleGlow
{
    public class Program
    {
        static void Main()
        {
            string art = @"


                 ______   __         ______   __       __        ______    ______    ______
                /      \ /  |       /      \ /  |  _  /  |      /      \  /      \  /      \
               /$$$$$$  |$$ |      /$$$$$$  |$$ | / \ $$ |     /$$$$$$  |/$$$$$$  |/$$$$$$  |
               $$ | _$$/ $$ |      $$ |  $$ |$$ |/$  \$$ |     $$ |  $$/ $$ \__$$/ $$____$$ |
               $$ |/    |$$ |      $$ |  $$ |$$ /$$$  $$ |     $$ |      $$      \  /    $$/
               $$ |$$$$ |$$ |      $$ |  $$ |$$ $$/$$ $$ |     $$ |   __  $$$$$$  |/$$$$$$/
               $$ \__$$ |$$ |_____ $$ \__$$ |$$$$/  $$$$ |     $$ \__/  |/  \__$$ |$$ |_____
               $$    $$/ $$       |$$    $$/ $$$/    $$$ |     $$    $$/ $$    $$/ $$       |
                $$$$$$/  $$$$$$$$/  $$$$$$/  $$/      $$/       $$$$$$/   $$$$$$/  $$$$$$$$/

                                          [F4] - Turn (ON / OFF) glow

";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Simple Glow CS2 by Capital0v";
            Console.WriteLine(art);

            Feature feature = new Feature();
        }
    }
}