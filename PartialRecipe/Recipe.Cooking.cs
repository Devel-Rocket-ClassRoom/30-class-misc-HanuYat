using System;

partial class Recipe
{
    public void AddIngredient(string ingredient)
    {
        if (Counts >= Ingredients.Length)
        {
            Console.WriteLine("재료가 꽉 찼습니다.");
            return;
        }

        for (int i = 0; i < Counts; i++)
        {
            if (string.Equals(ingredient, Ingredients[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("이미 있는 재료입니다.");
                return;
            }
        }

        Ingredients[Counts] = ingredient;
        Counts++;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료: ");
        
        for (int i = 0; i < Counts; i++)
        {
            Console.WriteLine($"   {i + 1}. {Ingredients[i]}");
        }
    }

    public bool HasIngredient(string ingredient)
    {
        for (int i = 0; i < Counts; i++)
        {
            if (string.Equals(ingredient, Ingredients[i], StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }
}