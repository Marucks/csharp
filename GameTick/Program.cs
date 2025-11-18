namespace GameTick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ct = 0;
            for (int i = 0; i < 1000; i++)
            {
                bool result = Prob();
                if (result == true)
                {
                    ct++;
                }
            }
            Console.WriteLine("True bolo:" + ct + "x");
        }

        public static bool Prob()
        {
            Random rando = new Random();
            int nahodneCislo = rando.Next(0,101);
            if (nahodneCislo >= 73)
            {
                return true;
            }
            return false;
            
        }



    }
}
