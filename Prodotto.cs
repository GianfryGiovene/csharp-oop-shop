using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/*
 Un prodotto è caratterizzato da:
-codice (numero intero)
-nome
-descrizione
-prezzo
-iva
alla creazione di un nuovo prodotto
    -il codice sia valorizzato con un numero random
    -Il codice prodotto sia accessibile solo in lettura
    -Gli altri attributi siano accessibili sia in lettura che in scrittura
    -Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
    -Il prodotto esponga un metodo per avere il nome esteso (ottenuto concatenando codice + nome Nella vostro programma principale)
 */


namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int productCode;
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public int iva = 22;


        public Prodotto(string name)
        {
            Random rnd = new Random();

            this.ProductName = name;
            this.productCode = rnd.Next(100, 1001);

        }
        public int GetProductCode()
        {
            return productCode;
        }

        public float GetPriceNoIva()
        {
            return this.ProductPrice;
        }

        public float GetPriceWithIva()
        {
            return (this.ProductPrice * 22) / 100;
        }

        public string GetExtendedName()
        {
            string numberToString = this.productCode.ToString();

            return numberToString + this.ProductName ;
        }

        /*BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
        */

        public string GetCodeWithPadLeft()
        {
            string productCode = this.productCode.ToString();

            while (productCode.Length < 8)
            {
                productCode = "0" + productCode;
            }

            return productCode;
        }

    }
}

