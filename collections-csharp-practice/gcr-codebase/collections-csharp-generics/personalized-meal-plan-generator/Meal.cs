using System;
public class Meal<T> where T : IMealPlan
{
    private List<T> meals = new List<T>();

    public void AddMeal(T meal)
    {
        meals.Add(meal);
    }

    public void DisplayAll()
    {
        foreach (var meal in meals)
        {
            meal.Display();
        }
    }

    public List<T> GetAll()
    {
        return meals;
    }
}
