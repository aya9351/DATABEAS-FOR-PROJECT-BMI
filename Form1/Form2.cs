//using final_Project.Data;
//using final_Project.Models;
namespace final_Project
{
    internal class Form2
    {
        private string userName;
        private double height;
        private double weight;
        private double bmiValue;
        private string bmiCategory;

        public Form2(string userName, double height, double weight, double bmiValue, string bmiCategory)
        {
            this.userName = userName;
            this.height = height;
            this.weight = weight;
            this.bmiValue = bmiValue;
            this.bmiCategory = bmiCategory;
        }
    }
}