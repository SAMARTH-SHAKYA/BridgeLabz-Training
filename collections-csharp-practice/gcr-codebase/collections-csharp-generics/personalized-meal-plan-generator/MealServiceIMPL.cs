using System;
public class MealServiceIMPL : IMealService
{
    private Meal<VegetarianMeal> vegetarianMeals = new Meal<VegetarianMeal>();
    private Meal<VeganMeal> veganMeals = new Meal<VeganMeal>();
    private Meal<KetoMeal> ketoMeals = new Meal<KetoMeal>();
    private Meal<HighProteinMeal> proteinMeals = new Meal<HighProteinMeal>();

    public void AddVegetarianMeal()
    {
        var meal = new VegetarianMeal("Paneer Salad", 350);
        MealUtility.ValidateAndGenerate(meal);
        vegetarianMeals.AddMeal(meal);
    }

    public void AddVeganMeal()
    {
        var meal = new VeganMeal("Quinoa Bowl", 300);
        MealUtility.ValidateAndGenerate(meal);
        veganMeals.AddMeal(meal);
    }

    public void AddKetoMeal()
    {
        var meal = new KetoMeal("Grilled Chicken", 450);
        MealUtility.ValidateAndGenerate(meal);
        ketoMeals.AddMeal(meal);
    }

    public void AddHighProteinMeal()
    {
        var meal = new HighProteinMeal("Egg Whites & Oats", 500);
        MealUtility.ValidateAndGenerate(meal);
        proteinMeals.AddMeal(meal);
    }

    public void ShowAllMeals()
    {
        Console.WriteLine("\n--- Vegetarian Meals ---");
        vegetarianMeals.DisplayAll();

        Console.WriteLine("\n--- Vegan Meals ---");
        veganMeals.DisplayAll();

        Console.WriteLine("\n--- Keto Meals ---");
        ketoMeals.DisplayAll();

        Console.WriteLine("\n--- High Protein Meals ---");
        proteinMeals.DisplayAll();
    }
}
