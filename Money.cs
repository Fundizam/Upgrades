using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    //-----Variables--------------
    int money;
    int diviser = 10;

    GameData gameData;

    private void Start()
    {
        gameData = FindObjectOfType<GameData>();
        Debug.Log("Is gameData called? " + gameData.isActiveAndEnabled);
    }
    private int CoinConversion()
    {
        if (FindObjectsOfType<GameData>().Length < 0)
        {
            Debug.LogWarning("No GameStatus object found. Play the game first!");
            return 0;
        }
        else
        {
            money = gameData.GetScore() / diviser;
            //Debug.Log(money += gameData.GetScore() / diviser);
            return money;
        }
    }
    public int GetMoney()
    {
        CoinConversion();
        //Debug.Log("Money on conversion: " + money);
        return money;
    }
}
