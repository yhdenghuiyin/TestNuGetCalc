// See https://aka.ms/new-console-template for more information

using TestNuGetCalc;

ICalcHelper calcHelper = new CalcHelper();

int res1 = calcHelper.Add(1, 2);
Console.WriteLine($"加法结果：{res1}");

int res2 = calcHelper.Subtract(1, 2);
Console.WriteLine($"减法结果：{res2}");

string res3 = calcHelper.AddForJson(1, 2);
Console.WriteLine($"加法json结果：{res3}");

string res4 = calcHelper.SubtractForJson(1, 2);
Console.WriteLine($"加法json结果：{res4}");
