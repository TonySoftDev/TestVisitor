// See https://aka.ms/new-console-template for more information
using TestVisitor.Base;
using TestVisitor.Concrete;

Console.OutputEncoding = System.Text.Encoding.UTF8; //Serve per la codifica dell'output altrimenti non mostrava il carattere €

Console.WriteLine("Inizio calcolo");


List<IVisitable<Item>> itemsList = new List<IVisitable<Item>>
{
    new ItemSoldInPieces("C010", "Penna") { NumberOfPieces = 2, UnitPrice=0.50 },
    new ItemSoldInPieces("C011", "Quadernone") { NumberOfPieces = 5, UnitPrice=1.50 },
    new ItemSoldInWeight("A100", "Mele") { Weight=1000, UnitPrice=0.01 },
    new ItemSoldInWeight("A101", "Ananas") { Weight=1000, UnitPrice=0.02 }
};

double totale = CalcolaTotale(itemsList);

Console.WriteLine($"Totale prodotti: € {totale}");


// Metodo di supporto per il calcolo
double CalcolaTotale(List<IVisitable<Item>> items)
{
    double dRet = 0.0;
    ShoppingVisitor visitor = new ShoppingVisitor();

    foreach (var item in items)
    {
        dRet += item.Accept(visitor);
    }

    return dRet;
}



