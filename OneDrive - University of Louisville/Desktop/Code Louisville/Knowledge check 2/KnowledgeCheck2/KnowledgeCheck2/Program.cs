

using KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var icecreamList = new List<FlavoredIcecream>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var icecream = new FlavoredIcecream();

    Console.WriteLine("Enter an icecream flavor");
    icecream.flavor = Console.ReadLine();

    Console.WriteLine("Enter the price of " + icecream.flavor);
    icecream.price = Console.ReadLine();

    Console.WriteLine("Enter a review of " + icecream.flavor);
    icecream.review = Console.ReadLine();

    icecreamList.Add(icecream);
}

// Print out the list of records using Console.WriteLine()

foreach (FlavoredIcecream icecream in icecreamList)
{
    Console.WriteLine("Icecream: " + icecream.flavor + " Price: " + (icecream.price) + " Review: " + (icecream.review));
}
