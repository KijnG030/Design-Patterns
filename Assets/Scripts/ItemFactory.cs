using UnityEngine;

public class ItemFactory
{
    public IItem Create(ItemType type)
    {
        switch (type)
        {
            case ItemType.Pistol:
                return new Pistol();

            case ItemType.Shotgun:
                return new Shotgun();

            default:
                return null;
        }
    }
}




