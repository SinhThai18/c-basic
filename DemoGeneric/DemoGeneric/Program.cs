internal class Program
{
    class Product<A>
    {
       private A id;

       public void setID(A id) 
        { 
             this.id = id;
        }

       public void printSP()
        {
            Console.WriteLine(this.id);
        }
    }
    public static void swap<T>(ref T x , ref T y)
    {
        T t = x;
        x = y;
        y = t;
       
    }
    private static void Main(string[] args)
    {
        int a = 5;
        int b = 6;

        Console.WriteLine("so a la {0} so b la {1}",a,b);
         swap(ref a , ref b);
        Console.WriteLine("so a la {0} so b la {1}", a, b);

        Product<int> product = new Product<int>();
        product.setID(16);
        product.printSP();
    }
}