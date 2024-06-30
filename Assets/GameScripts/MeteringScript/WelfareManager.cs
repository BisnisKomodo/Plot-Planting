using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WelfareManager : MonoBehaviour
{
    [SerializeField] public float currentwelfare;
    [SerializeField] private float maxwelfare;

    public float remainingwelfarepercentage
    {
        get
        {
            return currentwelfare / maxwelfare;
        }
    }

    public UnityEvent OnWelfareChanged;

    public void welfarereduce(float welfarereduction)
    {
        if (currentwelfare == 0)
        {
            return;
        }
        
        currentwelfare -= welfarereduction;
        OnWelfareChanged.Invoke();

        if (currentwelfare < 0)
        {
            currentwelfare = 0;
        }

    }

    public void welfareincrease(float welfaretoadd)
    {
        if (currentwelfare == maxwelfare)
        {
            return;
        }
        currentwelfare += welfaretoadd;
        
        if (currentwelfare > maxwelfare)
        {
            currentwelfare = maxwelfare;
        }
        OnWelfareChanged.Invoke();
    }
}
