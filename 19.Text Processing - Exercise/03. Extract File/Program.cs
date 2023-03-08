﻿string[] input = Console.ReadLine().Split("\\"); // => [C:, Internal, training-internal, Template.pptx]
string file = input[input.Length - 1]; // => Template.pptx
string[] splitLastWord = file.Split('.'); // => [Template, pptx]
string fileName = splitLastWord[0];
string extension = splitLastWord[1];
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extension}");