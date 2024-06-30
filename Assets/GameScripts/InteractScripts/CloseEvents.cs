using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseEvents : MonoBehaviour
{
    public float welfaretoadd;
    public float EntertaintmentToAdd;
    public float educationadd;
    public float welfarereduction;
    public float entertaintmentreduction;
    public float educationreduction;
    private WelfareManager welfaremanager;
    private EntertaintmentManager entertaintmentmanager;
    private EducationManager educationmanager;
    public GameObject eventPanel;
    public BudgetManager budgetmanager;
    void Start()
    {
        welfaremanager = FindObjectOfType<WelfareManager>().GetComponent<WelfareManager>();
        entertaintmentmanager = FindObjectOfType<EntertaintmentManager>().GetComponent<EntertaintmentManager>();
        educationmanager = FindObjectOfType<EducationManager>().GetComponent<EducationManager>();
    }

    public void Startnextday()
    {
        budgetmanager.AddMoney(10);
        welfaremanager.welfareincrease(welfaretoadd);
        entertaintmentmanager.entertaintmentincrease(EntertaintmentToAdd);
        educationmanager.educationincrease(educationadd);
        welfaremanager.welfarereduce(welfarereduction);
        entertaintmentmanager.entertaintmentreduce(entertaintmentreduction);
        educationmanager.educationreduce(educationreduction);

        if (eventPanel != null)
        {
            eventPanel.SetActive(false);
        }
    }
}
