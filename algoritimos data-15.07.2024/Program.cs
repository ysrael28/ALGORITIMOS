/*
using System.IO.Compression;

void Mensagem() {
    Console.WriteLine("olá mundo");
}

//Mensagem();

void Escreva(string msg){
    Console.WriteLine(msg);
}

Escreva("olá");
Escreva("tú é neimar?");
Escreva("se não...");

string minhamsg = "tú não sabe meno";
Escreva(minhamsg);


void MostraIdade(string nome, int idade){
    Escreva($"{nome} tem {idade} anos");
}

MostraIdade("fulando", 16);
MostraIdade("sicrano", 19);

void calcularIdade(string nome, int ano){
    int idade = 2024 - ano;
    MostraIdade(nome,idade);
}

calcularIdade("fulaninho", 2010);

int MaiorEntre(int a, int b){
    if(a >= b){
        return a;
    }
    else{
        return b;
    }
}
Console.WriteLine(MaiorEntre(99,200));
Console.WriteLine(MaiorEntre(15,7));
Console.WriteLine(MaiorEntre(1,1));

float resultado;

resultado = (2*100 + 3*50) / 5f;
Console.WriteLine("a media é: " + resultado);

resultado = (2*70 + 3*50) / 5f;
Console.WriteLine("a media é: " + resultado);

resultado = (2*99 + 3*33) / 5f;
Console.WriteLine("a media é: " + resultado);

void calcularmedia(int a,int b){
    float resultado = (a+b)/2f;
    Console.WriteLine("a media é: " + resultado);
}

calcularmedia(100,50);
calcularmedia(19,50);
calcularmedia(32,50);
*/





void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("erro de divisao por zero");
        return;
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}

//variáveis globais
float a;
float b;

void DigitarAeB(string operacao){
    Console.WriteLine(operacao);
    Console.WriteLine("digite o valor de a:");
    a = float.Parse(Console.ReadLine());
     Console.WriteLine("digite o valor de b:");
    b = float.Parse(Console.ReadLine());   
}

//menu
Console.WriteLine("--- calculadora ---");
Console.WriteLine("|1 - soma           |");
Console.WriteLine("|2 - subtração      |");
Console.WriteLine("|3 -- multiplicação |");
Console.WriteLine("|4 - divisão        |");
Console.WriteLine("|5 - sair           |");
Console.WriteLine("-------------------");
Console.WriteLine("digite a opção desejada");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("soma");
    Soma(a,b);
}
else if(opcao == 2){
    DigitarAeB("multiplicação");
    subtracao(a,b);
}
else if(opcao == 3){
    DigitarAeB("multiplicação");
    multiplicacao(a,b);
}
else if(opcao == 4){
    DigitarAeB("divisão");
    divisao(a,b);
}
else if(opcao == 5){
    Console.WriteLine("saindo");
    }
    else{
        Console.WriteLine("opção inválida");
}
