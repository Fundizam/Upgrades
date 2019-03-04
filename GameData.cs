using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    Player player;
    DamageDealer damageDealer;
    //----Variables---------------------
    int score = 500000;
    int playerDamage;
    int playerHealth;
    private void Start()
    {
        player = FindObjectOfType<Player>();
        damageDealer = FindObjectOfType<DamageDealer>();
    }
    public int GetDamageContained()
    {
        playerDamage = damageDealer.GetDamage();
        Debug.Log("player damage is: " + playerDamage);

        return playerDamage;
    }
    public int GetHealthContained()
    {
        playerHealth = player.GetHealth();
        Debug.Log("player health is: " + playerHealth);

        return playerHealth;
    }
    public int GetScore()
    {
        return score;
    }
}