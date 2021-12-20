namespace Task2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter gross salary amount:");
            var input = Console.ReadLine();
            double grossAmount = Convert.ToDouble(input);

            double netAmount = CalculateTaxes(grossAmount);
            Console.WriteLine("Net amount is {0}", netAmount);
        }

        static double CalculateTaxes(double grossAmount)
        {
            if (grossAmount <= 1000)
            {
                return grossAmount;
            }
            else
            {
                double excessAmount = grossAmount - 1000;
                double incomeTaxAmount = ((double)excessAmount / 100) * 10;
                if(grossAmount > 3000)
                {
                    excessAmount = 2000; 
                }
                double socialTaxAmount = ((double)excessAmount / 100) * 15;

                return grossAmount - incomeTaxAmount - socialTaxAmount;
            }
        }
    }

    // One way that additional taxes can be added programmaticaly is to capture the input from the console, asking the user to add any amount of additonal taxes and the amount that they should be taxed for
    // and store them in a dictionary. Afterwards check if the gross amount is above 1000 and loop through each tax and apply it to the excess amount.
}