using Duan2;

class Program
{
    static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("         Menu");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Choose your playing style");
        Console.WriteLine("   1.Player vs Player");
        Console.WriteLine("   2.Player vs Robot");
        Console.WriteLine("   3.Robot vs Robot");
        Console.ForegroundColor = ConsoleColor.Blue;
        int choose = int.Parse(Console.ReadLine());
        switch(choose)
        {
            case 1: 
                Console.WriteLine("Player vs Player");
                game.play1();
                break;
            case 2:
                Console.WriteLine("Player vs Robot");
                game.play();
                break;
            case 3:
                Console.WriteLine("Robot vs Robot");
                game.play2();
                break;
        }
        
      
        Console.ReadKey();
    }
}
