using System;

namespace ExtraSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            RemoveExtraSpaceCharacters(text);
        }

        static void RemoveExtraSpaceCharacters(string text)
        {
            string[] splittedText = text.Split(" ");
            string[] onlyWordsArray = new string[1];

            for (int i = 0; i < splittedText.Length; i++)
            {
                if (splittedText[i] != "")
                {
                    onlyWordsArray[onlyWordsArray.Length - 1] = splittedText[i];
                    Array.Resize(ref onlyWordsArray, onlyWordsArray.Length + 1);
                }
            }
            Console.WriteLine(string.Join(" ", onlyWordsArray));
        }
    }


}
