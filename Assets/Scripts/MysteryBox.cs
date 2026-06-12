using UnityEngine;

public class MysteryBox
{
    private ItemFactory factory;
    private IRewardStrategy rewardStrategy;

    public MysteryBox(
        ItemFactory factory,
        IRewardStrategy rewardStrategy)
    {
        this.factory = factory;
        this.rewardStrategy = rewardStrategy;
    }

    public IItem Open()
    {
        ItemType reward = rewardStrategy.GetReward();

        return factory.Create(reward);
    }
}
