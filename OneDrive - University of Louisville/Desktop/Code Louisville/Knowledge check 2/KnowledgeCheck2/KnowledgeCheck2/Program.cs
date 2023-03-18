

using KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var icecreamList = new List<Icecream>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var icecream = new Icecream();

    Console.WriteLine("Enter an icecream flavor");
    string icecreamFlavor = Console.ReadLine();
    icecream.flavor = new Flavor(icecreamFlavor);

    Console.WriteLine("Enter the price of " + icecream.flavor.name);
    icecream.price = Console.ReadLine();

    Console.WriteLine("Enter a review of " + icecream.flavor.name);
    icecream.review = Console.ReadLine();

    icecreamList.Add(icecream);
}

// Print out the list of records using Console.WriteLine()

foreach (Icecream icecream in icecreamList)
{
    Console.WriteLine("Icecream: " + icecream.flavor.name + " Price: " + (icecream.price) + " Review: " + (icecream.review));
}
