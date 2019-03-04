using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    //-----Variables--------------
    int money;
    int diviser = 10;

    public GameData gameData;

    private void Start()
    {
        //gameData = FindObjectOfType<GameData>();

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
            // alternative - without initialiser and declaration of the reference variable
            // money = FindObjectOfType<GameData>().GetScore() / diviser;
            return money;
        }
    }
    public int GetMoney()
    {
        CoinConversion();
        Debug.Log("Money on conversion: " + money);
        return money;
    }
}
