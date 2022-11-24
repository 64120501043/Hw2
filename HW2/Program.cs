class Program
{
    static void Main(string[] args)
    {
        Queue<char> Thai = new Queue<char>();
        while(true){
            Console.WriteLine("----------------");
            Console.WriteLine("L / M / S ");
            Console.WriteLine("Your Size : ");
            Console.WriteLine("----------------");
            char Fruit = char.Parse(Console.ReadLine());
            if (Fruit != 'L' && Fruit != 'M' && Fruit != 'S'){
                break;
            }
            else{
                Thai.Push(Fruit);
            }
        } 
        while(Thai.GetLength() != 0){
            char FLove = Thai.Pop();

            if(FLove == 'L'){
                Console.Write("1");
                Thai.Push('M');
                Thai.Push('M');
            }
            else if(FLove == 'M'){
                Console.Write("2");
                Thai.Push('S');
                Thai.Push('S');
                Thai.Push('S');
            }
            else if(FLove == 'S'){
                Console.Write("3");
            }
        }
    }
}