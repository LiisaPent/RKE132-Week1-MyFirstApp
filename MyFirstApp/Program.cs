// this is a comment to my code

// rakendus küsib kasutaja nime
// rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");  // output - kõik, mida kuvame
string userName = Console.ReadLine();  // input - kõik, mida sisestame

Console.WriteLine("Hello" + ", " + userName + "!");

// string interpolation
Console.WriteLine($"Hello, {userName}!");

