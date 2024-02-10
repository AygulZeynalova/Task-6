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
                double ratio = countA / countB;
                Console.WriteLine($"The '{a}' character is {ratio} times more than the '{b}' character.");
            }
            else
            {
                Console.WriteLine($"There is no '{b}' symbol in the text.");
            }

            Console.WriteLine("\n");
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?

            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string oddA = "This is the text that we will be doing our tasks on!";
            bool allOddIndexedCharsAreA = true;

            for (int i = 1; i < oddA.Length; i += 2)
            {
                if (oddA[i] != 'a')
                {
                    allOddIndexedCharsAreA = false;
                    break;
                }
            }

            if (allOddIndexedCharsAreA)
            {
                Console.WriteLine("All symbols under an odd index has an {a}");
            }
            else
            {
                Console.WriteLine("All symbols under an odd index are NOT {a}");
            }
            Console.WriteLine("\n");

            //3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.

            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string oddB = "This is the text that we will be doing our tasks on!";
            bool allOddIndexedCharsAreB = true;
            int count = 0;
            for (int i = 1; i < text.Length; i += 2)
            {
                if (text[i] == 'b')
                {
                    count++;
                }
            }

            if (!allOddIndexedCharsAreB)
            {
                Console.WriteLine("There are no b characters under odd indexes");
            }
            Console.WriteLine("\n");

            //4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?
            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string text1 = "This is the text that we will be doing our tasks on!";
            int index = text1.IndexOf('a');

            if (index != -1)
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine("The position of the first 'a' is even.");
                }
                else
                {
                    Console.WriteLine("The position of the first 'a' is odd.");
                }
            }
            else
            {
                Console.WriteLine("The character 'a' was not found in the text.");
            }

            Console.WriteLine("\n");

            //5) Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?

            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string text2 = "This is the text that we will be doing our tasks on!";

            int indexA = text2.IndexOf('a');

            int indexB = text2.IndexOf('b');

            int indexC = text2.IndexOf('c');

            int minIndex = text.Length;

            if (indexA != -1 && indexA < minIndex)
            {
                minIndex = indexA;
            }

            if (indexB != -1 && indexB < minIndex)
            {
                minIndex = indexB;
            }

            if (indexC != -1 && indexC < minIndex)
            {
                minIndex = indexC;
            }
            if (minIndex == text.Length)
            {
                Console.WriteLine("None of the characters {a}, {b}, {c} were found in the text.");
            }
            else if (minIndex == indexA)
            {
                Console.WriteLine("The character {a} appears first among {a}, {b}, {c} in the text.");
            }
            else if (minIndex == indexB)
            {
                Console.WriteLine("The character {b} appears first among {a}, {b}, {c} in the text.");
            }
            else
            {
                Console.WriteLine("The character {c} appears first among {a}, {b}, {c} in the text.");
            }
            Console.WriteLine("\n");
            //6) Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?

            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string text3 = "This is the text that we will be doing our tasks on!";

            int indexFromLeft = text3.IndexOf('a');
            int indexFromRight = text3.LastIndexOf('a');

            if (indexFromLeft == indexFromRight)
            {
                Console.WriteLine("The indexes of the character {a} from the left and right are the same.");
            }
            else
            {
                Console.WriteLine("The indexes of the character {a} from the left and right are not the same.");

            }

            Console.WriteLine("\n");
            //7) Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?
            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string text4 = "This is the text that we will be doing our tasks on!";

            int indexOfA = text4.IndexOf('a');
            int indexOfB = text4.IndexOf('b');
            int indexOfC = text4.IndexOf('c');

            int minIndex1 = text.Length;

            if (indexOfA < indexOfB && indexOfB < indexOfC)
            {
                Console.WriteLine("{a} comes before {b}, and {b} comes before {c} in the text.");
            }
            else if (minIndex1 == text.Length)
            {
                Console.WriteLine("None of the characters {a}, {b}, {c} were found in the text.");
            }

            else
            {
                Console.WriteLine("The order of {a}, {b}, and {c} in the text is not {a} -> {b} -> {c}.");
            }

            Console.WriteLine("\n");

            //8) Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et. 
            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string text5 = "This is the text that we will be doing our tasks on!";

            int indexOfA1 = text5.IndexOf('a');

            if (indexOfA1 != -1 && indexOfA1 + 1 < text5.Length)
            {
                char nextChar = text5[indexOfA1 + 1];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(nextChar);
                }
            }
            else
            {
                Console.WriteLine("The character 'a' was not found in the text, or there is no character after 'a'.");

            }
            Console.WriteLine("\n");

            //
        }
    }
}
