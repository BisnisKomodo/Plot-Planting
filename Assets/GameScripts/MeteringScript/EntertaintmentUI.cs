using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntertaintmentUI : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image entertaintmentforegroundimages;
    public void UpdateEntertaintmentBar(EntertaintmentManager entertaintmentmanager)
    {
        entertaintmentforegroundimages.fillAmount = entertaintmentmanager.remainingentertaintmentpercentage;
    }
}
