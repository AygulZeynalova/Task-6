namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?

            string text = "This is the text that we will be doing our tasks on!";
            Console.WriteLine(text);
            char a = 'a';
            char b = 'b'; 

            int countA = text.Count(c => c == a);
            int countB = text.Count(c => c == b);

            if (countB != 0)
            {
                double ratio =countA / countB;
                Console.WriteLine($"The '{a}' character is {ratio} times more than the '{b}' character.");
            }
            else
            {
                Console.WriteLine($"There is no '{b}' symbol in the text.");
            }


        }
    }
}
