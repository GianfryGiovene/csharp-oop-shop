/*
 Esercizio di oggi: C# Shop nome repo: csharp-oop-shop
Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
-codice (numero intero)
-nome
-descrizione
-prezzo
-iva Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
 alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random Il codice prodotto sia accessibile solo in lettura Gli altri attributi siano accessibili sia 
in lettura che in scrittura Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva Il prodotto esponga un metodo per avere il nome esteso, 
ottenuto concatenando codice + nome Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.

BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
Buon lavoro!
*/

using csharp_oop_shop;


Prodotto newProduct = new Prodotto("Pippo");

newProduct.ProductDescription = "lorem ipsum dolor";
newProduct.ProductPrice = float.Parse(Console.ReadLine());


Console.WriteLine("Codice prodotto: {0}", newProduct.GetProductCode());
Console.WriteLine("Nome prodotto: {0}", newProduct.ProductName);
Console.WriteLine("Descrizione prodotto:\n{0}", newProduct.ProductDescription);
Console.WriteLine("Prezzo prodotto: {0}", newProduct.ProductPrice);
Console.WriteLine("Nome esteso prodotto: {0}", newProduct.GetExtendedName());
Console.WriteLine(newProduct.GetCodeWithPadLeft());