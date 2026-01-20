using System;
public static class MealUtility
{
    public static void ValidateAndGenerate<T>(T meal) where T : IMealPlan
    {
        if (meal.Calories <= 0)
        {
            Console.WriteLine("Invalid meal: Calories must be positive.");
            return;
        }

        Console.WriteLine("Meal validated successfully!");
        meal.Display();
    }
}
