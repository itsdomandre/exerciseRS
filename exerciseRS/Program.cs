using System.Runtime.Serialization;
// 1 - welcome screen

Console.WriteLine("Digite o seu nome: ");
string welcome = Console.ReadLine();
Console.WriteLine("Olá, " + welcome + "! Seja muito bem-vindo!");

// 2 - concatenação

Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite o seu sobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine("Olá, " + nome + " " + sobrenome + "! Seja muito bem-vindo!");

//3 -» Calc

Console.WriteLine("Digite o PRIMEIRO valor que deseja calcular: ");
double value1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o SEGUNDO valor que deseja calcular: ");
double value2 = double.Parse(Console.ReadLine());

double soma = value1 + value2;
double subtracao = value1 - value2;
double multiplicacao = value1 * value2;
double divisao = value2 == 0 ? 0 : value1 / value2;
double media = (value1 + value2) / 2;

Console.WriteLine("O resultado da Soma é: " + soma);
Console.WriteLine("O resultado da Subtração é: " + subtracao);
Console.WriteLine("O resultado da Multiplicação é: " + multiplicacao);
Console.WriteLine("O resultado da Divisão é: " + divisao);
Console.WriteLine("A média entre os 2 números é: " + media);

//4 - Caracteres de uma palavra

Console.WriteLine("Digite uma palavra: ");
string palavra = Console.ReadLine();

int count = 0;

foreach (char i in palavra)
{
    if (i != ' ')
    {
        count++;
    }
}

Console.WriteLine("A palavra digitada possui: " + count + " caracteres.");

//5 - Validar placa

Console.WriteLine("Digite uma placa para verificar se ela é valida- Ex.: ABC1234");
string placa = Console.ReadLine();

if (placa.Length != 7)
{
    Console.WriteLine("Placa Inválida.");
    return;
}

for (int i = 0; placa.Length < 3; i++)
{
    if (!char.IsLetter(placa[i]))
    {
        Console.WriteLine("Placa Inválida");
        return;
    }
}

for (int i = 3; i < placa.Length; i++)
{
    if (!char.IsDigit(placa[i]))
    {
        Console.WriteLine("Placa inválida, verifique novamente.");
        return;
    }
}

Console.WriteLine("A placa digitada: " + placa + " é uma placa válida.");

// 6 - formato de hora
DateTime dataHoraAtual = DateTime.Now;

Console.WriteLine("Escolha o formato de data que deseja exibir:");
Console.WriteLine("1. Formato completo");
Console.WriteLine("2. Apenas a data (dd/mm/aaaa)");
Console.WriteLine("3. Apenas a hora (HH:mm:ss)");
Console.WriteLine("4. Data com o mês por extenso");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Formato completo: " + dataHoraAtual);
        break;
    case 2:
        Console.WriteLine("Apenas a data: " + dataHoraAtual.ToString("dd/MM/yyyy"));
        break;
    case 3:
        Console.WriteLine("Apenas a hora: " + dataHoraAtual.ToString("HH:mm:ss"));
        break;
    case 4:
        Console.WriteLine("Data com o mês por extenso: " + dataHoraAtual.ToString("dd 'de' MMMM 'de' yyyy"));
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
    