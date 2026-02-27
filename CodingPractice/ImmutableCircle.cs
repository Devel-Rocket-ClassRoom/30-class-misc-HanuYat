class ImmutableCircle
{
    public int Radius { get; }

    public ImmutableCircle(int radius)
    {
        Radius = radius;
    }

    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }
}