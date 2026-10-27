string frase;
int parole = 0, cparole = 0;

Console.WriteLine("Inserisci una frase ");
frase = Console.ReadLine();

for (int i = 0; i < frase.Length; i++)
{
    if (frase[i] == ' ')
    {
        parole++;
        cparole = parole + 1;
    }


}
Console.WriteLine("Il numero di parole è " + cparole);