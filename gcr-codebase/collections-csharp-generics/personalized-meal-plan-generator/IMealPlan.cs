using System;
public interface IMealPlan
{
    string MealName { get; }
    int Calories { get; }
    void Display();
}
