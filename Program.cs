Console.Clear();
int idade;

Console.Write("Qual a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18 && idade <= 67)
{
    Console.WriteLine("Você pode doar seu sangue");
}
else
{
    Console.WriteLine("Você não pode doar seu sangue");
}