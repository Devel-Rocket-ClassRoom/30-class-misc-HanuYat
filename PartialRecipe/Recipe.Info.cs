partial class Recipe
{
    public string Name { get; }
    public int Servings { get; }

    public string[] Ingredients;
    public int Counts;

    public Recipe(string name, int servings, int maxCount)
    {
        Name = name;
        Servings = servings;
        Counts = 0;

        Ingredients = new string[maxCount];
    }
}