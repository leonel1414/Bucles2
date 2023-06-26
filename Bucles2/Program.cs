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