#region CalculationTask
using CalculationTask.Interfaces;
using CalculationTask.Models;

Calculation calculation = new();
calculation.Sum(2, 3);
calculation.Minus(5, 4);
calculation.Multiple(7, 3);
calculation.Divide(6, 3);

Console.WriteLine(calculation.Sum(2, 3));
Console.WriteLine(calculation.Minus(5,4));
Console.WriteLine(calculation.Multiple(7,3));
Console.WriteLine(calculation.Divide(6,3));

#endregion

