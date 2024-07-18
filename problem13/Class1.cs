using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem13
{
    class BMICalculator
    {
        public Stack<double> bmiHistory = new Stack<double>();

        public double CalculateBMI(double height, double weight)
        {
            double bmi = weight / (height * height);
            AddBMIHistory(bmi);
            return bmi;
        }
        
        
        public string GetBMICategory(double bmi)
        {
            AddBMIHistory(bmi);
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal Weight";
            else if (bmi < 30)
                return "Overweight";
            else
                return "Obesity";
        }

        public void AddBMIHistory(double bmi)
        {
            bmiHistory.Push(bmi);
        }
        public void show_history(double height, double weight, double bmi)
        {
            Console.WriteLine($"""
                height : {height} m
                width : {weight} m
                bmi : {bmi} m^-2 
                """);
        }
    }
}
