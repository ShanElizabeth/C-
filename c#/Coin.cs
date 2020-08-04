using Random;
namespace Coin{

    public class Coin{
public static int CoinToss()
        {
            System.Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int toss = rand.Next(1, 3);
            if (toss == 1)
            {
                System.Console.WriteLine("Heads it is!");
                return toss;
            }
            else
            {
                System.Console.WriteLine("It's tails!");
                return toss;
            }
        }
        public static void TossMultipleCoins(int num)
        {
            int i = 0;
            while (i < num)
            {
                CoinToss();
                i++;
            }
        }
    }
}