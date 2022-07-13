namespace Pbj
{
    class Program
    {
        static void Main(string[] args)
        {


            bool order = true;
            while (order)
            {

                int bread = 2;
                int peanutButter = 2;
                int jelly = 4;

                Console.Write("Good afternoon! \nHow many people are we making sandwiches for? ");
                int sandwiches = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" alright, " + sandwiches + " sandwiches coming right up!! To get started...\n");

                int slicesOfBread = sandwiches * bread;
                int tbspOfPeanutButter = sandwiches * peanutButter;
                int tspOfJelly = sandwiches * jelly;

                Console.Write("\n You will need: \n" + slicesOfBread + " slices of bread, \n");
                Console.WriteLine(tbspOfPeanutButter + " tablespoons of peanut butter, ");
                Console.WriteLine("and " + tspOfJelly + " teaspoons of jelly.\n");


                double totalLoavesNeeded = Math.Ceiling((double)slicesOfBread / 28);
                double totalJarsofPbNeeded = Math.Ceiling((double)tbspOfPeanutButter / 32);
                double totalJellyNeeded = Math.Ceiling((double)tspOfJelly / 48);

                Console.Write("which means we need: \n" + totalLoavesNeeded + " loaves of bread, \n");
                Console.WriteLine(totalJarsofPbNeeded + " jar(s) of peanut butter, \n" + totalJellyNeeded + " jar(s) of jelly.\n");
                Console.WriteLine("Would you like to change you order?");


                string restartOrder = Console.ReadLine();
                if ((restartOrder == "yes") || (restartOrder == "y"))
                {

                }
                else
                {
                    Console.WriteLine("Goodbye.");
                    order = false;
                }
            }




        }

    }
}

