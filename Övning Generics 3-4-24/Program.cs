namespace Övning_Generics_3_4_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();

            boxList.Add(new Box(1, 2, 3));
            boxList.Add(new Box(2, 2, 3));
            boxList.Add(new Box(3, 2, 3));
            boxList.Add(new Box(4, 2, 3));
            boxList.Add(new Box(4, 2, 3));//Lägger till dubblett för att säkerställa att den ej läggs till.

            Display(boxList);
            Console.WriteLine("-------------------------");

            boxList.Remove(new Box(3, 2, 3));

            Display(boxList);
            Console.WriteLine("-------------------------");


            //Kolla ifall en specifik box finns i listan. 
            if(boxList.Contains(new Box(1, 2, 3)))
            {
                Console.WriteLine("Box exist.");
            }
            else
            {
                Console.WriteLine("Box doesn't exist. ");
            }

        }

        public static void Display(BoxCollection boxCol)
        {
            foreach(Box box in boxCol)
            {
                Console.WriteLine(box);
            }
        }

        
    }
}
