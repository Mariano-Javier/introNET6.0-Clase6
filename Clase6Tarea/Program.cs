int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21); // Genera un numero entero aleatorio de 1 a 20
int contador = 1;
int num;
bool verificador;
int numero=0;

Console.WriteLine("¡Adivine el número secreto generado por la computadora!\n--Ingrese un número del 1 al 20--");

do
{
    string input = Console.ReadLine();
    verificador = int.TryParse(input, out num);

    if (verificador)
    {
        numero = int.Parse(input);

        if (numero < 1 || numero > 20)
        {
            Console.WriteLine("¡Solamente números del 1 al 20!\n--Ingrese nuevamente un número--");
            contador++;
        }

        else if (numero > numeroSecreto)
        {
            Console.WriteLine("El número ingresado es mayor al número secreto\n--Ingrese nuevamente un número más chico--");
            contador++;
        }

        else if (numero < numeroSecreto)
        {
            Console.WriteLine("El número ingresado es menor al número secreto\n--Ingrese nuevamente un número más grande--");
            contador++;
        }
    }
    if (!verificador)
    {
        Console.WriteLine("Carácter inválido\n--Ingrese nuevamente un número--");
        contador++;
    }

}
while (numero != numeroSecreto);

if (numero == numeroSecreto)
{
    Console.WriteLine($"¡Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}!\nLo has logrado en {contador} intento/s!!");
}
