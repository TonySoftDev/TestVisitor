// See https://aka.ms/new-console-template for more information
using TestVisitor.Base;
using TestVisitor.Concrete;

Console.OutputEncoding = System.Text.Encoding.UTF8; //Serve per la codifica dell'output altrimenti non mostrava il carattere €

Console.WriteLine("Inizio calcolo");

double CalcolaTotale(List<IVisitable> items)
{
    double dRet = 0.0;
    ShoppingVisitor visitor = new ShoppingVisitor();

    foreach (var item in items)
    {
        dRet += item.Accept(visitor);
    }

    return dRet;
}


List<IVisitable> itemsList = new List<IVisitable>
{
    new ItemSoldInPieces("C010", "Penna") { NumberOfPieces = 10, UnitPrice=0.20 },
    new ItemSoldInPieces("C011", "Quaderno") { NumberOfPieces = 5, UnitPrice=1.10 },
    new ItemSoldInWeight("A100", "Mele") { Weight=500, UnitPrice=0.01 },
    new ItemSoldInWeight("A101", "Ananas") { Weight=1000, UnitPrice=0.02 }
};

double totale = CalcolaTotale(itemsList);

Console.WriteLine($"Totale prodotti: € {totale}");
Console.ReadLine();






