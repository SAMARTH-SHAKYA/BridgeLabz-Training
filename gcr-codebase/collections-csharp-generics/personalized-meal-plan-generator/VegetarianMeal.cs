public class VegetarianMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public VegetarianMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void Display()
    {
        Console.WriteLine($"[Vegetarian] {MealName} - {Calories} calories");
    }
}
