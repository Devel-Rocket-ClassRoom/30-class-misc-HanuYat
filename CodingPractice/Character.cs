using System;
using static System.Net.Mime.MediaTypeNames;

partial class Character
{
    private string _name;
    private int _health;
    private int _level;

    public string Name => _name;
    public int Health => _health;
    public int Level => _level;

    public Character(string name)
    {
        _name = name;
        _health = 100;
        _level = 1;
    }
}

partial class Character
{
    public void TakeDamage(int damage)
    {
        _health -= damage;

        Console.WriteLine($"{_name}이(가) {damage}의 피해를 입음. 남은 체력: {_health}");
    }

    public void Heal(int amount)
    {
        _health += amount;

        Console.WriteLine($"{_name}이(가) {amount}만큼 회복함. 남은 체력: {_health}");
    }
}