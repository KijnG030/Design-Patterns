using UnityEngine;

public interface IRewardStrategy
{
    ItemType GetReward();
}

public class RandomRewardStrategy : IRewardStrategy
{
    public ItemType GetReward()
    {
        int value = Random.Range(0, 2);

        return (ItemType)value;
    }
}
