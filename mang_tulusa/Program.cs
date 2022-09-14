using mang_tulusa;
using System.Text;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Tegelane tegelane = new Tegelane("asd");
tegelane.info();*/
UTF8Encoding utf8 = new UTF8Encoding();

try
{
    Console.WriteLine("Tere!");
    Peaklass.Uus_mang(19);
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Fail esemed.txt ei ole täidetud!");
}
catch (FileNotFoundException)
{
    Console.WriteLine("fail esemed.txt ei ole loodud");
}

