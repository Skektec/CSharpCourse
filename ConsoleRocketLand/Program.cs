namespace ConsoleRocketLand;

class Program
    {
        static void Main(string[] args)
    {
        string rocket1 =
            "      /\\\n     /  \\\n    |    |\n    |    |\n    | /\\ |\n   /|/  \\|\n  / |    | \\\n /  |    |  \\\n/___|____|___\\\n  | |    | |\n  |_|____|_|";

        string rocket2 =
            "      /\\\n     /  \\\n    |    |\n    |    |\n    | /\\ |\n   /|/  \\|\n  / |    | \\\n /  |    |  \\\n/___|____|___\\\n  | |    | |\n  |_|____|_|\n    \\  /\n     \\/";

        string rocket3 = "      /\\\n     /  \\\n    |    |\n    |    |\n    | /\\ |\n   /|/  \\|\n  / |    | \\\n /  |    |  \\\n/___|____|___\\\n  | |    | |\n  |_|____|_|\n  / \\  / \\\n |   VV   |\n \\  /  \\  /\n  \\/    \\/\n   |    |\n   |    |\n";

        string rocketAsset = "";
        
        int j = 0;
        int i;
        
       for (i = 0; i < 30; i++)
       {
           j = i;

           while (j != 0)
           {
               Console.WriteLine("\n");
               j--;
           }
           
           if (i <= 13)
           {
                rocketAsset = rocket3;
           } 
           else if (i <= 27)
           {
               rocketAsset = rocket2;
           }
           else
           {
               rocketAsset = rocket1;
           }
           
           Console.WriteLine(rocketAsset);
           Thread.Sleep(200);
           Console.Clear();
           
       }

       j = i;
       
       while (j != 0)
       {
           Console.WriteLine("\n");
           j--;
       }
       Console.WriteLine(rocketAsset);
       Console.ReadKey();
    }
}
