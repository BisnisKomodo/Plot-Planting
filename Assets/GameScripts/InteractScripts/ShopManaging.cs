using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManaging : MonoBehaviour
{
    private CanvasGroup shops;
    public GameObject[] optioning;

    void Awake()
    {
        shops = GetComponent<CanvasGroup>();
    }
    public void ClosesShop()
    {
        shops.alpha = 0f;
        shops.blocksRaycasts = false;
        shops.interactable = false;
    }

    public void SelectingBuilding(int index)
    {
        for(int i = 0; i < optioning.Length; i++)
        {
            if(i == index)
            {
                optioning[i].SetActive(true);
            } 
            else
            {
                optioning[i].SetActive(false);
            }
        }
    }
}
