// See https://aka.ms/new-console-template for more information

// rakendus palub kasutajal valida sugu (m/f)
// rakendus palub kasutajal sisestada perekonnanimi
// lähtudes kasutaja valikust, tervitab rakendus kasutajat järgmiselt
// "Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); // loeb konsoolist andmeid string (sõne) formaadis


Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();


if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine("Welcome!");
}