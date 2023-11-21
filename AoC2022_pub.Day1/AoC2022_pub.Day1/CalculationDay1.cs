namespace AoC2022_pub.Day1
{
    internal class CalculationDay1
    {
        string[] lines = File.ReadAllLines("..\\testAoC2022.txt"); //NOTE: The file needs to be placed in Debug folder of the application

        List<int> caloriesPerElf = new List<int>();
        List<int> totalElfsCalories = new List<int>();

        int totalCalPerElf = 0;
        int maxCalories = 0;

        public int CalculateMaxCal() //PROBLEM: It sums only the first one and doesn't continue. 
        {
            foreach (string line in lines)
            {

                if (String.IsNullOrEmpty(line)) //Revert?
                {
                    totalElfsCalories.Add(CountCaloriesPerElf());
                }

                continue;

            }
            maxCalories = totalElfsCalories.Max();
            Console.WriteLine($"{maxCalories}");
            return maxCalories;
        }
        private int CountCaloriesPerElf()
        {
            try
            {
                foreach (string line in lines)
                {
                    if (String.IsNullOrEmpty(line))
                        break;

                    int parsedCal;
                    bool success = int.TryParse(line, out parsedCal);
                    if (success)
                    {
                        caloriesPerElf.Add(parsedCal);
                    }
                    else
                    {
                        Console.WriteLine($"Conversion of '{line}' to {parsedCal} failed");
                    }
                    //int parsedCal = int.Parse(line);

                }
                foreach (int cal in caloriesPerElf)
                {
                    totalCalPerElf = caloriesPerElf.Sum();
                }
                return totalCalPerElf;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}
