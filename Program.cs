int[] quantity = new int[] {6,8,12,5,10,17};

for (int i=0; i<quantity.Length; i++)
{
    Console.WriteLine("Quantity "+i+" = "+quantity[i]);
}

foreach (int qty in quantity)
{
    Console.WriteLine("Quantity = "+qty);
}

Console.ReadKey();
