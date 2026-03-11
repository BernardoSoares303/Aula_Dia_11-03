
int Escolha;

do
{
    Console.Clear();

    Console.WriteLine("=================================");
    Console.WriteLine("|        Programa Dia 11/03     |");
    Console.WriteLine("=================================");
    Console.WriteLine("| 1. Fazer Media Ponderada      |");
    Console.WriteLine("| 2. Descontar 10%              |");
    Console.WriteLine("| 3. Mostrar Aumento de 15%     |");
    Console.WriteLine("| 4. Mostrar Consumo Carro      |");
    Console.WriteLine("| 5. Sair                       |");
    Console.WriteLine("=================================");

    Console.Write("Escolha uma das opções acima: ");
    Escolha = int.Parse(Console.ReadLine());

    Console.Clear();

    switch(Escolha)
    {
        case 1:
            
            Console.Write("Insira a 1° nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Insira a 2° nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double Media = (nota1 * 2 + nota2 * 3) / (2+3);

            Console.WriteLine($"A media ponderada é: {Media}");

            Console.WriteLine();
            Console.Write("Prexione Qualquer tecla para voltar ao menu...");

            Console.ReadKey(true);

            break;
        
        case 2:
            
            Console.Write("Insira o Valor Do Produto: ");
            double preco = double.Parse(Console.ReadLine());

            double descontado = preco * 0.9;

            Console.WriteLine($"O preço com 10% de desconto é {descontado}");

            Console.WriteLine();
            Console.Write("Prexione Qualquer tecla para voltar ao menu...");

            Console.ReadKey(true);

            break;
        
        case 3:
            
            Console.Write("Insira o Salario do funcionario: ");
            double Salario = double.Parse(Console.ReadLine());

            double Valoraumento = Salario * 0.15;
            double SalarioAumentado = Salario + Valoraumento;

            Console.WriteLine($"O funcionario teve um amento de R${Valoraumento}, seu novo salario total é de R${SalarioAumentado}");
            
            Console.WriteLine();
            Console.Write("Prexione Qualquer tecla para voltar ao menu...");

            Console.ReadKey(true);

            break;
        
        case 4:

            Console.Write("Insira a distancia percorrida pelo carro(km): ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("insira a quantidade de gasolina gasta(L): ");
            double gasolina_gasta = double.Parse(Console.ReadLine());

            double Consumo = distancia / gasolina_gasta;

            Console.WriteLine($"O carro consome {Consumo}km/litro");

            Console.WriteLine();
            Console.Write("Prexione Qualquer tecla para voltar ao menu...");

            Console.ReadKey(true);

            break;

        case 5:
            break;

        default:
            Console.WriteLine("Opção Invalida!"); 
            Console.Write("Prexione Qualquer tecla para voltar ao menu...");

            Console.ReadKey(true);
            break;
    }
}while(Escolha != 5);
