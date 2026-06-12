using UnityEngine;

public class Game : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = new GameManager();
        gameManager.Initialize();
    }

    void Update()
    {
        gameManager.Update();
    }
}
