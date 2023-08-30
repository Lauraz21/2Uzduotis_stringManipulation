//2
Console.WriteLine("Iveskite sakini: ");
string text = Console.ReadLine();
text = text.Replace("a", "uo").Replace("i", "e");
Console.WriteLine(text);


//2.1

Console.WriteLine("Parasykite eilerasti arba dainos zodzius");
string lyrics = Console.ReadLine();

Console.WriteLine("Koki zodi norite pakeisti kitu zodziu");
string word = Console.ReadLine();

Console.WriteLine("I koki zodi norite pakeisti?");
string word2 = Console.ReadLine();

lyrics = lyrics.Replace(word, word2);
Console.WriteLine(lyrics);


//2.2


Console.WriteLine("Iveskite savo amziu");
int age = Convert.ToInt32(Console.ReadLine());
int userInput = 90 - age;
Console.WriteLine(userInput + " metai");
Console.WriteLine((userInput * 365) + " dienos");
Console.WriteLine((userInput * 52) + " savaites");
Console.WriteLine((userInput * 12) + " menesiai");

