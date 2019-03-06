using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    Player player;
    DamageDealer damageDealer;
    Upgrades upgrades;
    //----Variables---------------------
    private int score = 500000;
    private int playerDamage;
    private int playerHealth;

    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int gameDataCount = FindObjectsOfType<GameData>().Length;
        if (gameDataCount > 1)
        {
            DestroyItself();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void DestroyItself()
    {
        Destroy(gameObject);
    }

    private void Start()
    {
        if (FindObjectsOfType<Player>().Length < 1 && FindObjectsOfType<DamageDealer>().Length < 1)
        {
            return;
        }
        else
        {
            player = FindObjectOfType<Player>();
            damageDealer = FindObjectOfType<DamageDealer>();
            Debug.Log("Game data " + this.isActiveAndEnabled);
        }
        if (FindObjectsOfType<Upgrades>().Length < 1)
        {
            return;
        }
        else
        {
            upgrades = FindObjectOfType<Upgrades>();
        }


    }
    public int GetDamageContained()
    {
        //if (FindObjectsOfType<DamageDealer>().Length < 1)
        //{
        //    return;
        //}
        //else if(FindObjectsOfType<DamageDealer>().Length == 1)
        //{
            playerDamage = damageDealer.GetDamage();
            Debug.Log("player damage is: " + playerDamage);

            return playerDamage;
        //}

    }
    public int GetHealthContained()
    {
        //if (FindObjectsOfType<Player>().Length < 1)
        //{
        //    return;
        //}
        //else if(FindObjectsOfType<Player>().Length == 1)
        //{
            playerHealth = player.GetHealth();
            Debug.Log("player health is: " + playerHealth);

            return playerHealth;
        //}

    }
    public int GetScore()
    {
        return score;
    }
    /*
    private int UpdatedHealth()
    {
        playerHealth = upgrades.GetIncreasedHealth();
        return playerHealth;
    }

    private int UpdatedDamage()
    {
        playerDamage = upgrades.GetIncreasedDamage();
        return playerDamage;
    }
    */
}