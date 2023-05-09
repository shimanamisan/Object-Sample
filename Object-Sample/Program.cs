
using Object_Sample;

//var musuko = new Musuko(new Tsumma(50));
var musuko = new Musuko(Factories.Create(Factories.PlayKind.Tsumma, 50));

while (musuko.HeroRed.Play())
{
    Console.WriteLine("まだ遊べる");
    Console.WriteLine($"{musuko.Happiness()}");
}

Console.WriteLine($"{nameof(musuko.HeroRed)}は力尽きた");
