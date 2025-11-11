using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

double A;
double B;
double C;
double Delta; 
double Raiz; 
double X1; 
double X2;

Console.Clear();
Console.WriteLine("                          ***BHASKARA***");

while (true)
{
    Console.WriteLine("Insira o valor de A...:");
    if (double.TryParse(Console.ReadLine(), out A))
    {
        break; 
    }
    Console.WriteLine("ERRO: Por favor, insira um número válido.");
}
while (true)
{
    Console.WriteLine("Insira o valor de B...:");
    if (double.TryParse(Console.ReadLine(), out B))
    {
        break; 
    }
    Console.WriteLine("ERRO: Por favor, insira um número válido.");
}
while (true)
{
    Console.WriteLine("Insira o valor de C...:");
    if (double.TryParse(Console.ReadLine(), out C))
    {
        break; 
    }
    Console.WriteLine("ERRO: Por favor, insira um número válido.");
}
Delta = (B * B) - (4 * A * C);
Raiz = Math.Sqrt(Delta);
string Deltafor = Delta.ToString("F2");

Console.WriteLine($"Delta...:{Deltafor}");
if (Delta < 0)
{
    Console.WriteLine("Não existem raizes reais");
}
else
{
    X1 = (-B + Raiz) / (2 * A);
    X2 = (-B - Raiz) / (2 * A);
    string Raizfor = Raiz.ToString("F2");
    string X1for = X1.ToString("F2");
    string X2for = X2.ToString("F2");
    Console.WriteLine($"Raiz de Delta...:{Raizfor}");
    Console.WriteLine($"X1...:{X1for}");
    Console.WriteLine($"X2...:{X2for}");
}