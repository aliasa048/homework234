using System;

namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] human =
            {
                new Human (34,"Rafiq"),
                new Human (46,"Ehmed"),
                new Human (78 ,"Samir")
            };




            string search;
            do
            {
                Console.WriteLine("Axtaris deyerini daxil edin:");
                search = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(search));



            for (int i = 0; i < human.Length; i++)
            {
               if (human[i].Surname.Contains(search))
               {
                    Console.WriteLine(human[i].Age +" "+human[i].Surname);
               }
            }

            Console.WriteLine("say daxil edin");
            int number = Convert.ToInt32(Console.ReadLine());
            Milk[] milks = new Milk[number];
            Return(ref milks);
            
            static Milk[] Return (ref Milk[] milks)
            {
                for (int i = 0; i < milks.Length; i++)
                {
                    Milk milk = new Milk();
                    Console.WriteLine("mehsulu elave et");
                    milk.Name = Console.ReadLine();


                    Console.WriteLine("Price daxil edin");
                    milk.Price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Discountu daxil edin");
                    milk.FatParcent = Convert.ToInt32(Console.ReadLine());

                    milks[i] = milk;
                }

                return milks;





















            }

            

            












        }
        
            
    }
}
