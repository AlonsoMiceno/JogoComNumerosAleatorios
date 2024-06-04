
Random random = new Random();
int dano = random.Next(1,5);
int vilao = 10;
int heroi = 10;


while (vilao >= 0)
{
    dano = random.Next(1,5);
        Console.WriteLine($"Vilao sofreu dano de {dano} pontos e agora tem {vilao-dano} pontos de vida ");
        vilao = vilao-dano;
            if (vilao <=0) break;
              
    dano = random.Next(1,5);
        Console.WriteLine($"Heroi sofreu dano de {dano} pontos e agora tem {heroi-dano} pontos de vida ");
        heroi = heroi-dano;
             if (heroi <=0) break;              
 }

if (vilao <= 0)
Console.WriteLine("Heroi foi o vencedor");
if (heroi <= 0)
Console.WriteLine("Vilao foi o vencedor");       


