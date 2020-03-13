using System;



    class Program
    {
        static void Main(string[] args)
        {
         
        
            int pilihan=0;
            int X=0, Y=0;
            
            Console.WriteLine("Pilihan menu kalkulator");
            Console.WriteLine( );
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine( );
            Console.WriteLine(" Silahkan Masukan pilihan = ");
            pilihan= int.Parse(Console.ReadLine());
            
            if (pilihan==1)
            {
                Console.WriteLine("inputkan nilai X = ");
                X=int.Parse(Console.ReadLine());
                Console.WriteLine("inputkan nilai Y = ");
                Y=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + X + " + " + Y + " = " + Penambahan(X, Y));
            }
            
            else if (pilihan==2)
            {
                Console.WriteLine("inputkan nilai X = ");
                X=int.Parse(Console.ReadLine());
                Console.WriteLine("inputkan nilai Y = ");
                Y=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", X, Y, Pengurangan(X, Y));
            }
            
            else if (pilihan==3)
            {
                Console.WriteLine("inputkan nilai X = ");
                X=int.Parse(Console.ReadLine());
                Console.WriteLine("inputkan nilai Y = ");
                Y=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", X, Y, perkalian(X, Y));
            }
            else if (pilihan==4)
            {
                Console.WriteLine("inputkan nilai X = ");
                X=int.Parse(Console.ReadLine());
                Console.WriteLine("inputkan nilai Y = ");
                Y=int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", X, Y, pembagian(X, Y));
            }
            else 
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }
                 
            
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
          
        }
        static int Penambahan(int X, int Y)
        {
            return X + Y;
        }
        static int Pengurangan(int X, int Y)
        {
            return X - Y;
        }
        static int perkalian(int X, int Y)
        {
            return X * Y;
        }
        static int pembagian(int X, int Y)
        {
            return X / Y;
        }
    }

        
    

