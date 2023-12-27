using CodeExercises.Arrays;

var elements = ArrayExercises.GenerateElementFrequencyMap<int>([1,5,4,8,784,5,8,1,4,8]);
Console.WriteLine(string.Join("\n", elements.Select(x => $"Key: {x.Key} - Count: {x.Value}")));


Console.ReadLine();
