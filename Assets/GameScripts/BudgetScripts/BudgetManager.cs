using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BudgetManager : MonoBehaviour
{
    public int startingMoney = 25;
    public static int CurrentMoney { get; private set; }
    public TMP_Text budgettext;

    void Start()
    {
        InitializeMoney();
    }

    public void InitializeMoney()
    {
        CurrentMoney = startingMoney;
        UpdateMoneyUI();
    }

    public void AddMoney(int amount)
    {
        CurrentMoney += amount;
        UpdateMoneyUI();
    }

    public bool SpendMoney(int amount)
    {
        if (CurrentMoney >= amount)
        {
            CurrentMoney -= amount;
            UpdateMoneyUI();
            return true;
        }
        else
        {
            Debug.Log("Not enough money!");
            return false;
        }
    }

    void UpdateMoneyUI()
    {
        budgettext.text = "Budget : $" + CurrentMoney.ToString();
    }
}
