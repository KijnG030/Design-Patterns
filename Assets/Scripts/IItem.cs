public interface IItem
{
    string Name { get; }
}

public enum ItemType
{
    Pistol,
    Shotgun,
    AssaultRifle
}

public class Pistol : IItem
{
    public string Name => "Pistol";
}

public class Shotgun : IItem
{
    public string Name => "Shotgun";
}

