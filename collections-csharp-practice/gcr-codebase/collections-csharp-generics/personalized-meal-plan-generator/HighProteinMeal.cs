public class HighProteinMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public HighProteinMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void Display()
    {
        Console.WriteLine($"[High Protein] {MealName} - {Calories} calories");
    }
}
