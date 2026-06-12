using UnityEngine;

public class Player
{
    public int Points { get; private set; }

    public Player(int points)
    {
        Points = points;
    }

    public bool SpendPoints(int amount)
    {
        if (Points < amount)
            return false;

        Points -= amount;
        return true;
    }
}
