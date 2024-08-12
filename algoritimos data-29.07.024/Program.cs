
bool Resposta()
{
    inicioPergunta:
    string resposta = Console.ReadLine();

    if(resposta == "s")
    {
        return true;
    }
    else if(resposta == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("não entendi, responda apenas s/n");
        goto inicioPergunta;
    }
}

Console.WriteLine("quer jogar o jogo s/n");
if (Resposta() == false)
{
    goto finalJogo;
}

inicioJogo:

int menor = 0;
int maior = 10;
int numTentativas = 10;
bool jogoRodando = true;

Random rand = new Random();
int sorteado = rand.Next(menor, maior + 1);
Console.WriteLine($"pensei em um numero entre {menor} e {maior}. tente adivinhar!");

while(jogoRodando)
{
    Console.WriteLine($"tentativa {numTentativas}: ");
    int numDigitado = int.Parse(Console.ReadLine());
    if(numDigitado < sorteado) 
    {
        Console.WriteLine("muito baixo. tente novamente.");
        numTentativas--;
    }
    else if(numDigitado > sorteado) 
    {
        Console.WriteLine("muito alto. tente novamente");
        numTentativas--;
    }
    else
    {
        Console.WriteLine("parabéns! você acertou");
        jogoRodando = false;
    }
}
if(numTentativas == 0)
{
    Console.WriteLine($"acabaram as tentativas. o numero que eu pensei era  {sorteado}.");
    jogoRodando = false;
}

Console.WriteLine("quer jogar de novo? s/n");
if(Resposta() == true)
{
    goto inicioJogo;
}

finalJogo:
Console.WriteLine("então até a proxima!");