using System;
public class KetoMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public KetoMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void Display()
    {
        Console.WriteLine($"[Keto] {MealName} - {Calories} calories");
    }
}
