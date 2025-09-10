﻿decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

int first = 5;
int second = 7;

string message = first.ToString() + second.ToString();
Console.WriteLine(message);

string first1 = "5";
string second1 = "7";

int sum = int.Parse(first1) + int.Parse(second1);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);