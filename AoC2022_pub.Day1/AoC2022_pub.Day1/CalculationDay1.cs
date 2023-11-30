namespace AoC2022_pub.Day1
{
    internal class CalculationDay1
    {
        readonly string[] lines = File.ReadAllLines("..\\newInputAoC2022.txt"); //NOTE: The file needs to be placed in Debug folder of the application


        List<int> caloriesPerElf = new List<int>();
        List<int> totalElfsCalories = new List<int>();

        public int CalculateMaxCal() 
        {
            
            int maxCalories = CountCaloriesPerElf().Max();
            Console.WriteLine($"{maxCalories}");
            return maxCalories;
        }
        private List<int> CountCaloriesPerElf()
        {
            try
            {
               List<int> parsedCal = ConvertCalories(lines);

                for(int i = 0; i<parsedCal.Count; i++)
                {
                    while(parsedCal[i]!=0 && i<parsedCal.Count-1)
                    {
                        caloriesPerElf.Add(parsedCal[i]);
                        i++;
                    }
                    if (i == parsedCal.Count - 1)
                    {
                        caloriesPerElf.Add(parsedCal[i]);
                    }

                    totalElfsCalories.Add(caloriesPerElf.Sum());
                    caloriesPerElf.Clear();

                }

                return totalElfsCalories;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        private List<int> ConvertCalories(string[] lines)
        {
            int parsedCal;
            List<int> parsedCalories = new List<int>();
            foreach (string line in lines)
            {
                if(!String.IsNullOrEmpty(line))
                {
                    parsedCal = int.Parse(line);

                    parsedCalories.Add(parsedCal);
                }
                if(String.IsNullOrEmpty(line))
                {
                    parsedCalories.Add(0);
                }
            }
            return parsedCalories;
        }
    }
}
