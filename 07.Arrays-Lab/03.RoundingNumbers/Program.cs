﻿double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

for (int i = 0; i < inputNumbers.Length; i++)
{
    Console.WriteLine($"{inputNumbers[i]} => {Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero)}");

}





