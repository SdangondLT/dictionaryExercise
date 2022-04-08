using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Dictionary<int, Articles> products = CreateProducts();
                ShowProducts(products);
            } while (true);
            
        }

        public static Dictionary<int, Articles> CreateProducts()
        {
            Dictionary<int, Articles> products = new Dictionary<int, Articles>();
            Articles leche = new Articles("leche", 123, 2000, "no", 15);
            Articles arroz = new Articles("arroz", 456, 2000, "si", 10);
            Articles panela = new Articles("panela", 789, 2000, "no", 5);

            products.Add(leche.GetId(), leche);
            products.Add(arroz.GetId(), arroz);
            products.Add(panela.GetId(), panela);

            return products;

        }

        public static void ShowProducts(Dictionary<int, Articles> products)
        {
            Console.WriteLine("Escriba el codigo del articulo que desea verificar: ");
            int codOfArticle = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nombre del producto: {products[codOfArticle].GetName()}");
            Console.WriteLine($"Precio del producto: {products[codOfArticle].GetPrice()}");
            Console.WriteLine($"El producto es importado?: {products[codOfArticle].GetIsImported()}");
            Console.WriteLine($"Cantidad de productos en stock: {products[codOfArticle].GetCount()}");

        }
    }
}
