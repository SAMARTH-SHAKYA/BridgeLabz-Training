using System;
public class MealMenu
{
    private IMealService mealService;

    public MealMenu()
    {
        mealService = new MealServiceIMPL();
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n====== Personalized Meal Plan Generator ======");
            Console.WriteLine("1. Add Vegetarian Meal");
            Console.WriteLine("2. Add Vegan Meal");
            Console.WriteLine("3. Add Keto Meal");
            Console.WriteLine("4. Add High Protein Meal");
            Console.WriteLine("5. Show All Meals");
            Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    mealService.AddVegetarianMeal();
                    break;
                case 2:
                    mealService.AddVeganMeal();
                    break;
                case 3:
                    mealService.AddKetoMeal();
                    break;
                case 4:
                    mealService.AddHighProteinMeal();
                    break;
                case 5:
                    mealService.ShowAllMeals();
                    break;
                case 6:
                    return;
            }
        }
    }
}
