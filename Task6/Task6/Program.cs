using System.Text.RegularExpressions;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?

            string text = "This is the text that we will be doing our tasks on!";
            char a = 'a'; 
            char b = 'b'; 

            int countA = 0;
            int countB = 0;

            foreach (char c in text)
            {
                if (c == a)
                {
                    countA++;
                }
                else if (c == b)
                {
                    countB++;
                }
            }

            if (countB == 0)
            {
                Console.WriteLine("The character '{0}' does not occur in the string.", b);
            }
            else
            {
                double ratio = (double)countA / countB;
                Console.WriteLine($"The character a occurs {ratio} times more often than the character b.");
            }
            Console.WriteLine("###################");
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
            Console.WriteLine("###################");
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
            Console.WriteLine("###################");

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
            Console.WriteLine("###################");

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
            Console.WriteLine("###################");
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
            Console.WriteLine("###################");
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
            Console.WriteLine("###################");

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
            Console.WriteLine("###################");

            //9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.? 
            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string text6 = "This is the text that we will be doing our tasks on!";
            if (text6.Length >= 3)
            {
                string firstThree = text6.Substring(0, 3);
                string lastThree = text6.Substring(text6.Length - 3);
                string reversedLastThree = new string(lastThree.Reverse().ToArray());

                if (firstThree == reversedLastThree)
                {
                    Console.WriteLine("The first three characters are the same as the reverse of the last three characters.");
                }
                else
                {
                    Console.WriteLine("The first three characters are not the same as the reverse of the last three characters.");
                }
            }
            else
            {
                Console.WriteLine("The text is too short!");
            }
            Console.WriteLine("###################");
            //10) Verilmish metinde butun reqemleri legv et. 
            Console.WriteLine("This is the 1 text that we will be doing our tasks on!");
            string text7 = "This is the 1 text that we will be doing our tasks on!";
            string result = Regex.Replace(text, @"\d", "");
            Console.WriteLine(result);
            Console.WriteLine("###################");
            //11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve
            //eyni zamandan butun { b}
            //simvollarinin qabagina { a}
            //simvolunu yaz. 
            Console.WriteLine("This is the text that we will be doing our tasks on!");
            string text8 = "This is the text that we will be doing our tasks on!";

            string result1 = text8.Replace("a", "ba").Replace("b", "ab");
            Console.WriteLine(result1);
            Console.WriteLine("###################");
            //12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et. 
            string text9 = "This is the text that we will be doing our tasks on!";
            int firstA = text9.IndexOf('a');
            int lastA = text9.LastIndexOf('a');

            string result2 = "";
            for (int i = 0; i < text9.Length; i++)
            {
                if (text9[i] == 'a' && i != firstA && i != lastA)
                {
                    continue;
                }
                result2 += text9[i];
            }

            Console.WriteLine(result2);
            Console.WriteLine("###################");
            //13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et. 
            string text10 = "This is the text that we will be doing our tasks on!";
            string result3 = "";

            for (int i = 0; i < text10.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result3 += Char.ToLower(text10[i]);
                }
                else
                {
                    result3 += Char.ToUpper(text10[i]);
                }
            }

            Console.WriteLine(result3);
            Console.WriteLine("###################");
            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et. 
            string text11 = "This is the text that we will be doing our tasks on!";
            string result4 = "";
            for (int i = 0; i < text11.Length - 1; i++)
            {
                if (i % 2 != 0)
                {
                    result4 += Char.ToUpper(text11[i + 1]);
                }
                else
                {
                    result4 += text11[i];
                }
            }
            //müəllim bu hissəyə copilot ilə baxdım,tam olaraq nə edir anlamadım
            if (text11.Length % 2 == 0)
            {
                result4 += text11[text11.Length - 1];
            }

            Console.WriteLine(result4);
            Console.WriteLine("###################");
            // 15)* Verilmish metinde ilk ve son simvol eynidirse,
            //ve metn daxilinde yanashi gelen { a}
            //simvolu varsa,
            //ve metn daxilinde { b}
            //simvolu yoxdursa
            //o zaman bu metnde butun { c}
            //simvollari yox et ve
            //neticede alinan metn zerkalni olub olmadigini yoxla.
            string text12 = "ana";
            string result5 = "";
            char firstIndexOfSentence = text12[0];
            char lastIndexOfSentence = text12[text12.Length - 1];
            bool indexerA = text12.Contains("a");
            bool indexerB = text12.Contains("b");

            if (firstIndexOfSentence == lastIndexOfSentence && indexerA && !indexerB)
            {
                string deleteC = text12.Replace("c", "");
                result5 += deleteC;
                string reversed1= new string(result5.Reverse().ToArray());

                if (result5 == reversed1)
                {
                    Console.WriteLine("The resulting string is a palindrome.");
                }
                else
                {
                    Console.WriteLine("The resulting string is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("The conditions are not met");
            }






        }
    }
}
