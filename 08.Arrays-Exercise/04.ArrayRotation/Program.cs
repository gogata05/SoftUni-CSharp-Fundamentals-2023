﻿//51 47 32 61 21
//2

//47 32 61 21 51
//32 61 21 51 47

int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rotation = int.Parse(Console.ReadLine());

for (int j = 0; j < rotation; j++)
{
    int firstElement = inputNumbers[0];

	for (int i = 0; i < inputNumbers.Length - 1; i++)
	{
		inputNumbers[i] = inputNumbers[i+1];
	}
	inputNumbers[inputNumbers.Length - 1] = firstElement;
}
Console.WriteLine(string.Join(" ", inputNumbers));




