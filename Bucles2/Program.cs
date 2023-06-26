/*
//Bucles

//While = mientras

int i = 0;

Console.Write("Ciclo WHILE: ");
while (i < 10)
{
    Console.Write(i);
    i++;
}


//Do.. while = hacer..mientras
Console.Write("\nCiclo DO WHILE: ");
int k = 5;
do
{
    Console.Write(k + " ");
    k++;
} while (k < 10);

//FOR = para
Console.Write("\nCiclo FOR: ");
for (int j = 0; j <= 10; j++)
{
    Console.Write(" " + j);
}

//Foreach
Console.Write("\n");
var names = new List<string> { "leonel", "belen", "milena" };
foreach (var name in names)
{
    Console.WriteLine("Hola, " + name.ToUpper());
}

//BUCLES 2

// IF
Console.WriteLine("¿Que dia es hoy?");
string hoy = Console.ReadLine();
if (hoy == "Lunes")
{
    Console.WriteLine("Feliz Lunes");
}
else
{
    Console.WriteLine("Hoy no es Lunes");
}
*/

//SWITCH
/*
Console.WriteLine("¿Que dia es hoy?");
string hoy = Console.ReadLine();

switch (hoy) { 
    case "lunes":
        Console.WriteLine("Hoy es lunes");
        break;
    case "martes":
        Console.WriteLine("Hoy es martes");
        break;
    case "miercoles":
        Console.WriteLine("Hoy es miercoles");
        break;
    default:
        Console.WriteLine("Ese dia no existe");
        break;
}

//CONTINUE
for (int z =0; z <10; z++) {
    Console.WriteLine(z);
    if (z<5) {
        Console.WriteLine("z es mejor que 5");
        continue;
    }
}
*/
//Ejercicio 1 - While

//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

/*
1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10

Console.WriteLine("Ingrese un numero a multiplicar");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 0;

while (contador <10) {
    contador++;
     int resultado = contador * numero;
    Console.WriteLine(numero + " x "+ contador + " = "+ resultado);
}
*/


//Ejercicio 2 - Do while
//Escribe un programa que realice estos pasos:
//Reciba al menos un número por consola
//Determine si el número es positivo o negativo
//Presente un contador para cada tipo (positivo y negativo).
//Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.


int contador_positivo = 0;
int contador_negativo = 0;
int numero;
do {
    Console.WriteLine("Ingrese un numero");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        Console.WriteLine("El numero es positivo");
        contador_positivo++;
    }
    else if (numero < 0)
    {
        Console.WriteLine("El numero es NEGATIVO");
        contador_negativo++;
    }
    else {
        Console.WriteLine("El numero 0 es neutro");
    }

}while (numero != 0);

Console.WriteLine("El total de numero positivo es: " + contador_positivo);
Console.WriteLine("El total de numero Negativo es: " + contador_negativo);



