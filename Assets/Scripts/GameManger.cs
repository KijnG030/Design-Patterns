using UnityEngine;

public class GameManager
{
    private Player player;
    private MysteryBox mysteryBox;

    public void Initialize()
    {
        player = new Player(5000);

        ItemFactory factory = new ItemFactory();

        IRewardStrategy strategy =
            new RandomRewardStrategy();

        mysteryBox =
            new MysteryBox(factory, strategy);
    }

    public void Update()
    {
    }
}
