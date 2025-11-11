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


Console.WriteLine($"Delta...:{Delta:N2}");
if (Delta < 0)
{
    Console.WriteLine("Não existem raizes reais");
}
else if(Delta==0)
{
    X1 = (-B + Raiz) / (2 * A);
    Console.WriteLine($"Delta =0 , Valores de X1 e X2 são iguais...{X1}");

}
else
        {
            X1 = (-B + Raiz) / (2 * A);
            X2 = (-B - Raiz) / (2 * A);
            
            Console.WriteLine($"Raiz de Delta...:{Raiz:N2}");
            Console.WriteLine($"X1...:{X1:N2}");
            Console.WriteLine($"X2...:{X2:N2}");
        }