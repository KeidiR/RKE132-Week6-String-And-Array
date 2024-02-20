string hello = " we are the champions?"; // string - mitte primitiivne andmetüüp. Keerulisemad, hoitakse vahemälus eraldi kohas.
// oluline omadus --> lenght 
//tühiku kood --> 32. suured tähed --> 65-90. väikesed tähed 97-122.
int stringLength  = hello.Length; // lenGTH mitte lenght
// kaks võimalust tühiku eemaldamiseks:
//1. string trimmedString = hello.Trim(); // () --> teen midagi. Trim --> eemaldab tühikud enne sõnet ja peale sõnet
hello = hello.Trim();//2.
char firstLetter = hello[0]; // string tüüpi andmed on immutable
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);
Console.WriteLine(hello);

int wordCounter = 1;
for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    {
        wordCounter++;
    }
    //if (hello[i] == ' ')
    //{  
    //    wordCounter++; 
    //}
}
Console.WriteLine($"Word count in {hello}: {wordCounter} words.");
 