// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string a = "abcdefg我的世界";
int i = System.Text.Encoding.Unicode.GetBytes(a).Length;
//int i = System.Text.Encoding.UTF8.GetBytes(a).Length;

int j = a.Length;
Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine(System.Text.Encoding.Unicode.GetBytes("abcdefg").Length);
Console.WriteLine(System.Text.Encoding.Unicode.GetBytes("我的世界").Length);