using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GoogleHash.data; 
namespace GoogleHash
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("busy_day.in");
            var line1 = lines[0].Split(' ');

            int rows = int.Parse(line1[0]);
            int cols = int.Parse(line1[1]);
            int numD = int.Parse(line1[2] );
            int loadD = int.Parse(line1[4]);

            // Products  , Types And Wheights  !!! 
            List<Product> listProd = new List<Product>();

            int NumProdTypes = int.Parse(lines[1]) ;
            var prodWeights = lines[2].Split(' '); 
            for (int i = 0; i < NumProdTypes; i++)
            {
                listProd.Add(new Product(i, -1, int.Parse(prodWeights[i]))); 
            }

            // set Up wherehouse  4 
            int numHous = int.Parse(lines[3]);

            List<WherHouse> listHou = new List<WherHouse>(); 
            for (int j = 4; j < numHous*2; j+=2)
            {
                var coord = lines[j].Split(' '); 
                WherHouse wh = new WherHouse(int.Parse(coord[0]) , int.Parse(coord[1]));
                wh.setProd(listProd.Count);
                var w = lines[j+1].Split(' ') ;
                for (int k = 0; k < listProd.Count; k++)
                {
                    wh.p[k] = new Product(k,int.Parse(w[k]) , listProd.ElementAt(k).weight); 
                }
            }

            // reading  orders
            int orind = numHous*2+4 ; 
            int NumOr = int.Parse(lines[orind]) ;  ;
            for (int i = orind+1 ; i < NumOr*3; i+=3)
            {
                var coord = lines[i].Split(' ');
                int n = int.Parse(lines[i + 1]);
                Order o = new Order(int.Parse(coord[0]) , int.Parse(coord[1]) , n);
                var ps = lines[i+2].Split(' ') ;
                for (int j = 0; j < n; j++)
                {
                    o.p[j] = new Product( int.Parse(ps[j]) , 1 , listProd.ElementAt(int.Parse(ps[j])).weight ) ; 
                }
            }

        }
    }
}
