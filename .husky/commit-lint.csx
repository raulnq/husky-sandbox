using System.Text.RegularExpressions;
using Internal;

private var pattern = @"^feature/[aA-zZ]+-[\d]+(\s).+";
private var msg = File.ReadAllLines(Args[0])[0];

if (Regex.IsMatch(msg, pattern))
   return 0;

Console.WriteLine("Invalid commit message");
Console.WriteLine("e.g: feature/ABC-123 brief description of the commit");

return 1;