using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelfareUI : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image welfareforegroundimages;
    public void UpdateWelfareBar(WelfareManager welfaremanager)
    {
        welfareforegroundimages.fillAmount = welfaremanager.remainingwelfarepercentage;
    }
}
