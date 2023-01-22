public sealed class Singleton<T>
    where T : notnull, new()
{
    private static readonly T _instance = new();
    public static T Instance => _instance;
}