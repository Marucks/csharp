namespace Cvicenie_subor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("People_100.csv");
            WriteRodneCislo(text);
            MoneyCountAverage(text);
            MinMoneyCount(text);
        }

        public static void MoneyCountAverage(string[] text)
        {

        }
        public static void WriteRodneCislo(string[] text)
        {

        }
        public static void MinMoneyCount(string[] text)
        {
            int MinValue = 99999999;
            string minValuePerson = "";
            foreach (string line in text.Skip(1))
            {
                string[] split = line.Split(';');
                int accountValue = int.Parse(split[4]);
                if (accountValue < MinValue)
                {
                    MinValue = accountValue;
                    minValuePerson = split[0] + " " + split[1];
                }
            }
            Console.WriteLine(minValuePerson);
        }

    }
}
