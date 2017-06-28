using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much was the cost of your dinner?");
            double costPerPerson = double.Parse(Console.ReadLine());

            Console.WriteLine("How many people will be in your party?");
            double numberOfPeople = double.Parse(Console.ReadLine());

            //double totalCost = numberOfPeople * costPerPerson;
            // Console.WriteLine(totalCost);

            double costForAll = numberOfPeople * costPerPerson;
            double costAboveOrEqualTo50;
            double billSplitUp;
            if (costForAll >= 50)
            {
                costAboveOrEqualTo50= costForAll * .1;
                double costsAddedUpon= (costForAll-costAboveOrEqualTo50);
                Console.WriteLine(costsAddedUpon);
                //confused here having an issue between dicount and split bill
                billSplitUp = costAboveOrEqualTo50 / numberOfPeople;
                Console.WriteLine("Each person will pay $" + billSplitUp);
            }
            else
            {
                double costUnder50 = costForAll * .5;
                Console.WriteLine("Your Total Is: " + (costForAll - costUnder50));
                billSplitUp = costUnder50 / numberOfPeople;
                Console.WriteLine("Each person will pay $" + billSplitUp);
            }
            //Next Problem 
            Console.WriteLine("Welcome! What is the name on the reservation?");
            string reserveName = Console.ReadLine();

            Console.WriteLine("And how many people are in your party?");
            double thoseInYourParty = double.Parse(Console.ReadLine());

            double finalCost = double.Parse(Console.ReadLine());
            Console.WriteLine(thoseInYourParty * finalCost);

            Console.WriteLine("Reservation:" + reserveName);
            Console.WriteLine("Total Due: $" + costForAll);
 //how can i split the bill up, divie it up 
        }
    }
}
