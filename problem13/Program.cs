namespace problem13
{
    internal class Program
    {

            static void Main(string[] args)
            {
                BMICalculator bmiCalculator = new BMICalculator();


                Console.WriteLine("Enter your height (in meters):");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your weight (in kilograms):");
                double weight = double.Parse(Console.ReadLine());


                double bmi = bmiCalculator.CalculateBMI(height, weight);


                Console.WriteLine($"Your BMI is: {bmi}");
                Console.WriteLine($"BMI Category: {bmiCalculator.GetBMICategory(bmi)}");


                bmiCalculator.AddBMIHistory(bmi);
                bmiCalculator.show_history(height, weight, bmi);
                Console.ReadLine();
            }
        
    }
}
