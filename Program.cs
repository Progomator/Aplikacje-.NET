using System;

namespace lab4
{
    class Program
    {
        public static void zad1 (int[] Arr ){

            foreach (int elem in Arr){
                Console.WriteLine(elem);
            }

        }
        

        public static void zad2 (int[,,] Arr){

            for (int el=Arr.Rank-1; el>=0; el-- ){
                for (int i=0; i<Arr.GetLength(el); i++){
                    for (int j=0; j<Arr.GetLength(el); j++){
                        for (int k=0; k<Arr.GetLength(el); k++){
                            Arr[i,j,k] = 0;
                        }
                    }
                }
            }

        }


        public static int [,] zad3(int arrHeight, int arrLength, int[,] Arr){
            int[,] ArrTrsp = new int [arrLength,arrHeight];
             
            for (int i=arrLength-1; i>=0; i--){
                for (int j=arrHeight-1; i>=0; i--){
                    ArrTrsp[i,j] = Arr[j,i];
                }
            }

            return ArrTrsp;
        }


        static void Main(string[] args)
        {
            //  1. Napisz funkcję, która przyjmować będzie tablicę dwuwymiarową o dowolnym rozmiarze,
            //     i wypisze wszystkie jej elementy.

            int[] Arr1 = new int[5] {1, 2, 3, 4, 5};
            


            //  2. Napisz funkcję, która przyjmie tablicę wielowymiarową (więcej niż 2 wymiary)
            //     i wyzeruje jej elementy.

            int[,,] Arr2 = new int[,,] { 
                                            { 
                                                {111, 112, 113 },
                                                {121, 122, 123 }, 
                                                {131, 132, 133 }
                                            },
                                            { 
                                                {211, 221, 231 },
                                                {221, 222, 223 },
                                                {231, 232, 233 }
                                            }, 
                                            {
                                                {311, 312, 313 },
                                                {321, 322, 323 },
                                                {331, 332, 333}
                                            }
                                        };
            zad2(Arr2);
            
            // Sprawdzenie:
            int dim1 = Arr2.GetLength(0);
            int dim2 = Arr2.GetLength(1);
            int dim3 = Arr2.GetLength(2);
                
            for (int i=0; i<dim1; i++){
                for (int j=0; j<dim2; j++){
                    for (int k=0; k<dim3; k++){
                        Console.WriteLine(Arr2[i,j,k]);
                    }
                }
            }
            


            // 3. Napisz program, który wykona transpozycję macierzy 4x5.
            //    Transpozycja macierzy polega na zamianie wierszy z kolumnami.
            //    Liczby generujemy losowo z przedziału [-9; 9].
            //    Elementami macierzy są liczby całkowite.
            
            int[,] Arr3 = new int[5,4];
            var r = new Random();
            
            Console.WriteLine("Tablica przed transpozycją: ");
            for (int i=4; i>=0; i--){
                for (int j=3; j>=0; j--){
                    Arr3[i,j] = r.Next(-9,10);
                    Console.Write($"{Arr3[i,j]}, ");
                }
                Console.WriteLine();
            }

            int [,] ArrTrsp = zad3(5,4,Arr3);
            
            Console.WriteLine("Tablica przed transpozycją: ");
            for (int i=3; i>=0; i--){
                for (int j=4; j>=0; j--){
                    Console.Write($"{Arr3[j,i]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
