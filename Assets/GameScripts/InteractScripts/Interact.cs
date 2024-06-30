using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    private bool canInteract = false;
    private CanvasGroup shops;
    public GameObject Buildings;
    private BudgetManager budgetmanager;
    private WelfareManager welfaremanager;
    private EntertaintmentManager entertaintmentmanager;
    private EducationManager educationmanager;
    public int sellValue = 2;
    private PlayerMovement playermovement;

    void Start()
    {
        welfaremanager = FindObjectOfType<WelfareManager>().GetComponent<WelfareManager>();
        entertaintmentmanager = FindObjectOfType<EntertaintmentManager>().GetComponent<EntertaintmentManager>();
        educationmanager = FindObjectOfType<EducationManager>().GetComponent<EducationManager>();
        budgetmanager = FindObjectOfType<BudgetManager>().GetComponent<BudgetManager>();
        playermovement = FindObjectOfType<PlayerMovement>();
    }
    void Awake()
    {
        shops = GameObject.Find("Canvas/ShopMenu").GetComponent<CanvasGroup>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            canInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            canInteract = false;
        }
    }

    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            shops.alpha = 1f;
            shops.blocksRaycasts = true;
            shops.interactable = true;
            playermovement.SetCanMove(false);
        }
    }

    public void EndInteraction()
    {
        shops.alpha = 0f;
        shops.blocksRaycasts = false;
        shops.interactable = false;
        playermovement.SetCanMove(true);
    }

    public void Builds(GameObject Building, int money, float welfaretoadd, float EntertaintmentToAdd, float educationadd, float welfarereduction, float entertaintmentreduction, float educationreduction)
    {
        if(Buildings != null)
        {
            Debug.Log("Building Occupied");
            budgetmanager.AddMoney(money);
            return;
        }
        Buildings = Instantiate(Building, transform.position, transform.rotation);
        welfaremanager.welfareincrease(welfaretoadd);
        entertaintmentmanager.entertaintmentincrease(EntertaintmentToAdd);
        educationmanager.educationincrease(educationadd);
        welfaremanager.welfarereduce(welfarereduction);
        entertaintmentmanager.entertaintmentreduce(entertaintmentreduction);
        educationmanager.educationreduce(educationreduction);
    }

    public void SellBuilding()
    {
        if (Buildings != null)
        {
            budgetmanager.AddMoney(sellValue);  // Add money for selling the building
            Destroy(Buildings);  // Destroy the building game object
            Buildings = null;  // Reset the building reference
        }
        else
        {
            Debug.Log("No building to sell!");
        }
    }
}
