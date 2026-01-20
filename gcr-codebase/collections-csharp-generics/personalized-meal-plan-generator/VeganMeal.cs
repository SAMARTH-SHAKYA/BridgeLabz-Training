using System;
public class VeganMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public VeganMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void Display()
    {
        Console.WriteLine($"[Vegan] {MealName} - {Calories} calories");
    }
}
