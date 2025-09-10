const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

int startSpan = input.IndexOf("<span>") + "<span>".Length;
int endSpan = input.IndexOf("</span>");
string quantity = $"Quantity: {input[startSpan..endSpan]}";

string output = input.Replace("&trade;", "&reg;")
                     .Replace("<div>", "")
                     .Replace("</div>", "");

output = "Output: " + output;

Console.WriteLine(quantity);
Console.WriteLine(output);
