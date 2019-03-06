using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Upgrades : MonoBehaviour
{
    //------Object references------------
    Money money;
    GameData gameData;

    //------Money-------------
    int cashForSpending  = 0;

    [SerializeField] Text moneyValueText;

    //-----Health--------------
    int newPlayerHealth;
    int healthCost = 100;
    int healthModifier = 50;

    [SerializeField] Text healthText;
    [SerializeField] Text healthCostText;

    //-----Damage----------------
    int newPlayerDamage;
    int damageCost = 70;
    int damageModifier = 10;

    [SerializeField] Text damageText;
    [SerializeField] Text damageCostText;


    private void Start()
    {
        //-------Money---------------------
        money = FindObjectOfType<Money>();
        cashForSpending += money.GetMoney();
        moneyValueText.text = cashForSpending.ToString();
        Debug.Log(cashForSpending += money.GetMoney());
        gameData = FindObjectOfType<GameData>();


        //------Health---------------------
        newPlayerHealth = gameData.GetHealthContained();
        Debug.Log("Health from GameData: " + gameData.GetHealthContained());

        healthText.text = newPlayerHealth.ToString();
        healthCostText.text = healthCost.ToString();

        //-------Damage---------------------
        newPlayerDamage = gameData.GetDamageContained();
        Debug.Log("Damage from GameData: " + gameData.GetDamageContained());

        damageText.text = newPlayerDamage.ToString();
        damageCostText.text = damageCost.ToString();
    }

    private void Update()
    {
        moneyValueText.text = cashForSpending.ToString();
    }

    //-------Health--------Health---------Health------------//
    private int IncreaseHealthCost()
    {
        if (cashForSpending > healthCost)
        {
            healthCost *= 2;
            return healthCost;
        }
        else
        {
            return healthCost;
        }
    }
    private int DecreaseMoneyOnHealthClick()
    {
        if (cashForSpending > healthCost)
        {
            cashForSpending -= healthCost;
            return cashForSpending;
        }
        else
        {
            return cashForSpending;
        }
    }
    private int IncreaseHealth()
    {
        if (cashForSpending > healthCost)
        {
            newPlayerHealth += healthModifier;
            return newPlayerHealth;
        }
        else
        {
            return newPlayerHealth;
        }
    }
    public void OnClickHealth()
    {
        DecreaseMoneyOnHealthClick();
        healthCostText.text = IncreaseHealthCost().ToString();
        healthText.text = IncreaseHealth().ToString();
    }

    public int GetIncreasedHealth()
    {
        IncreaseHealth();
        return newPlayerHealth;
    }


    //-------Damage---------Damage------------Damage----------------//

    private int IncreaseDamageCost()
    {
        if (cashForSpending > damageCost)
        {
            damageCost *= 2;
            return damageCost;
        }
        else
        {
            return damageCost;
        }
    }
    private int DecreaseMoneyOnDamageClick()
    {
        if (cashForSpending > damageCost)
        {
            cashForSpending -= damageCost;
            return cashForSpending;
        }
        else
        {
            return cashForSpending;
        }
    }
    private int IncreaseDamage()
    {
        if (cashForSpending > damageCost)
        {
            newPlayerDamage += damageModifier;
            return newPlayerDamage;
        }
        else
        {
            return newPlayerDamage;
        }
    }
    public void OnClickDamage()
    {
        DecreaseMoneyOnDamageClick();
        damageCostText.text = IncreaseDamageCost().ToString();
        damageText.text = IncreaseDamage().ToString();
    }

    public int GetIncreasedDamage()
    {
        IncreaseDamage();
        return newPlayerDamage;
    }
}
