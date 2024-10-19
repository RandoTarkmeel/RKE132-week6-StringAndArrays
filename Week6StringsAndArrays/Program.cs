string hello = "we are the champions?";

int stringlength = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstletter = hello[0];
Console.WriteLine(firstletter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstletter = hello[0];
Console.WriteLine(firstletter);

Console.WriteLine(hello);




//int wordcounter = 0;

//for (int i = 0; i < hello.Length; i++) 
//{
//    if (char.IsWhiteSpace(hello[i]))
//    { 
//        wordcounter++; 
//    }
//}

//Console.WriteLine($"word count in {hello}: {wordcounter + 1} words.");