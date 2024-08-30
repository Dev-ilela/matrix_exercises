//1. Armazenar seis valores em uma matriz de ordem 3x2.
//Apresentar os valores na tela.
int a, b, cont = 1;
int[,] matriz = new int[3, 2];

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 2; b++)
    {
        Console.Write($@"Digite o {cont}° valor : ");
        matriz[a, b] = int.Parse(Console.ReadLine());
        cont++;
    }
}

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 2; b++)
    {
        Console.WriteLine($@"O valor da posição {a},{b} é {matriz[a,
        b]}");
    }
}

Console.ReadKey();

//2.Entrar via teclado com doze valores e armazená-los em uma matriz
//de ordem 3x4.
//Após a digitação dos valores solicitar uma constante multiplicativa,
//que deverá multiplicar cada valor matriz e armazenar o resultado na
//própria matriz, nas posições correspondentes.
int a, b, cont = 1;
int constMulti;
int[,] matriz = new int[3, 4];

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 4; b++)
    {
        Console.Write($@"Digite o {cont}° valor : ");
        matriz[a, b] = int.Parse(Console.ReadLine());
        cont++;
    }
}

Console.Write($@"Favor, digite uma constante multiplativa : ");
constMulti = int.Parse(Console.ReadLine());

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 4; b++)
    {
        matriz[a, b] *= constMulti;
    }
}

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 4; b++)
    {
        Console.WriteLine($@"Multiplicada por {constMulti}, o valor da
posição {a},{b} resultou em {matriz[a, b]}");
    }
}

Console.ReadKey();

//3. Entrar via teclado com doze valores e armazená-los em umamatriz de ordem 3x4.
//Após a digitação dos valores solicitaruma constante multiplicativa,
//que deverá multiplicar cada valor matriz e
//armazenar o resultado em outra matriz de mesma ordem, nas posições
//correspondentes. Exibir as matrizes na tela,
//sob a forma matricial, ou seja, linhas por colunas.
int a, b, cont = 1;
int constMulti;
int[,] matriz = new int[3, 4];
int[,] matriz2 = new int[3, 4];

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 4; b++)
    {
        Console.Write($@"Digite o {cont}° valor : ");
        matriz[a, b] = int.Parse(Console.ReadLine().ToString());
        cont++;
    }
}

Console.Write($@"Favor, digite uma constante multiplativa : ");
constMulti = int.Parse(Console.ReadLine());

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 4; b++)
    {
        matriz2[a, b] = matriz[a, b] * constMulti;
    }
}

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 4; b++)
    {
        Console.Write("{0,5}", matriz[a, b]);
    }
    Console.WriteLine();
}

for (a = 0; a < 3; a++)
{
    for (b = 0; b < 4; b++)
    {
        Console.Write("{0,5}", matriz2[a, b]);
    }
    Console.WriteLine();
}

//4. Entrar com uma matriz de ordem MxN, onde a ordem também será
//escolhida pelo usuário, sendo que no máximo 10x10.
//Após a digitação dos elementos, criar e exibir a matriz transposta.
int a, b, x, z, cont = 1;

do
{
    Console.Write($@"Digite o N° de linhas que deseja (Até 10): ");
    a = int.Parse(Console.ReadLine().ToString());
}
while (a > 10);

do
{
    Console.Write($@"Digite o N° de colunas que deseja (Até 10): ");
    b = int.Parse(Console.ReadLine().ToString());
}

while (b > 10);

int[,] matriz = new int[a, b];

for (x = 0; x < a; x++)
{
    for (z = 0; z < b; z++)
    {
        Console.Write($@"Digite o {cont}° valor : ");
        matriz[x, z] = int.Parse(Console.ReadLine());
        cont++;
    }
}

for (x = 0; x < a; x++)
{
    for (z = 0; z < b; z++)
    {
        Console.Write("{0,10}", matriz[x, z]);
    }
    Console.WriteLine();
}

//5.Criar um programa para controlar as reservas de poltronas de uma
//peça teatral, sabendo que o teatro possui “X” seções de “Y” fileiras com “Z” cadeiras cada.
//Os valores de “X”, “Y” e “Z” serão digitados. O usuário digita seu
//nome, número da seção, fileira e cadeira que pretende reservar, e se estiver livre a reserva será efetuada,
//caso contrário, o programa deverá enviar mensagem comunicando que a cadeira está ocupada e
//solicitar outro lugar. Perguntar ao usuário se mais alguém pretende fazer reservas. As reservas poderão ser efetuadas
//até completar um máximo de quatro quintos da capacidade total do teatro. No final do programa de reservas, exibir um “mapa”
//mostrando as cadeiras do teatro com os nomes de cada ocupante, ou ainda com a informação “Livre”.
int qtSecao , qtFileira, qtCadeira, secao, fileira, cadeira, contador = 0;
string nome;
char resp;

Console.WriteLine("Olá! Seja bem-vindo ao Teatro Municipal de São Paulo!");
Console.Write($@"Digite quantas seções o teatro possui : ");
qtSecao = int.Parse(Console.ReadLine());

Console.Write($@"Agora, Digite quantas fileiras o teatro possui : ");
qtFileira = int.Parse(Console.ReadLine());

Console.Write($@"E agora, Digite quantas cadeiras o teatro possui : ");
qtCadeira = int.Parse(Console.ReadLine());

string[,,] teatro = new string[qtSecao, qtFileira, qtCadeira];
for (secao = 0; secao < qtSecao; secao++)
    for (fileira = 0; fileira < qtFileira; fileira++)
        for (cadeira = 0; cadeira < qtCadeira; cadeira++)
        {
            if (teatro[secao, fileira, cadeira] == null)
            {
                teatro[secao, fileira, cadeira] = "LIVRE";
            }
        }

do
{
    Console.Write("Digite o seu nome : ");
    nome = Console.ReadLine();
    do {
        Console.Write($@"Digite o setor (1 a {qtSecao}) : ");
        secao = int.Parse(Console.ReadLine());
    } while (secao > qtSecao);
    do
    {
        Console.Write($@"Digite a fileira (1 a {qtFileira}) : ");
        fileira = int.Parse(Console.ReadLine());
    } while (fileira > qtFileira);
    do
    {
        Console.Write($@"Digite a cadeira (1 a {qtCadeira}) : ");
        cadeira = int.Parse(Console.ReadLine());
    } while (cadeira > qtCadeira);
    if (teatro[secao - 1, fileira - 1, cadeira - 1] == "LIVRE")
    {
        teatro[--secao, --fileira, --cadeira] = nome;
    }
    else
    {
        Console.WriteLine($@"Cadeira já preenchida, favor escolher outro assento.");
    }

    contador++;

    resp = 'N';

    if (contador < (qtSecao * qtFileira * qtCadeira) * 0.8)
    {
        Console.Write("Deseja continuar (S/N)? ");
        resp = char.Parse(Console.ReadLine().ToUpper());
    }
} while (resp != 'N' && (contador < (qtSecao * qtFileira * qtCadeira) * 0.8));

Console.WriteLine("Assentos:");

for (secao = 0; secao < qtSecao; secao++)
    for (fileira = 0; fileira < qtFileira; fileira++)
        for (cadeira = 0; cadeira < qtCadeira; cadeira++)
        {
            Console.Write(teatro[secao, fileira, cadeira]);
            Console.WriteLine();
        }

Console.ReadKey();