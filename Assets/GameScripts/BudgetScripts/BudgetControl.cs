using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BudgetControl : MonoBehaviour
{
    public BudgetManager budgetmanager; 
    public float welfaretoadd;
    public float EntertaintmentToAdd;
    public float educationadd;
    public float welfarereduction;
    public float entertaintmentreduction;
    public float educationreduction;
    public GameObject Building1;
    private WelfareManager welfaremanager;
    private EntertaintmentManager entertaintmentmanager;
    private EducationManager educationmanager;
    PlayerMovement player;

    void Start()
    {
        welfaremanager = FindObjectOfType<WelfareManager>().GetComponent<WelfareManager>();
        entertaintmentmanager = FindObjectOfType<EntertaintmentManager>().GetComponent<EntertaintmentManager>();
        educationmanager = FindObjectOfType<EducationManager>().GetComponent<EducationManager>();
        budgetmanager.InitializeMoney();
    }

    public void Bought(int money)
    {
        bool purchaseSuccess = budgetmanager.SpendMoney(money);
        player = FindObjectOfType<PlayerMovement>();
        if (purchaseSuccess)
        {
            Debug.Log("Purchase successful!");
            // player.CheckLandV2();
            // Debug.Log(player.interacting.Buildings);
            // if(player.interacting.Buildings != null)
            // {
            //     Debug.Log("ada isinya");
            //     return;
            // }
            player.CheckLand(Building1, money, welfaretoadd, EntertaintmentToAdd, educationadd, welfarereduction, entertaintmentreduction, educationreduction);
            // welfaremanager.welfareincrease(welfaretoadd);
            // entertaintmentmanager.entertaintmentincrease(EntertaintmentToAdd);
            // educationmanager.educationincrease(educationadd);
            // welfaremanager.welfarereduce(welfarereduction);
            // entertaintmentmanager.entertaintmentreduce(entertaintmentreduction);
            // educationmanager.educationreduce(educationreduction);
        }
    }

    
}
