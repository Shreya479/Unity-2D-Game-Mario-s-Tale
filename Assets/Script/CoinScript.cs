using UnityEngine;
using System.Collections;
public class CoinScript : MonoBehaviour
{
    private LevelManager gameLevelManager;
    public int coinValue;
    void Start()
    {
        gameLevelManager = FindObjectOfType<LevelManager>();
    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameLevelManager.AddCoins(coinValue);
            Destroy(gameObject);
        }
    }
}
