using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EntertaintmentManager : MonoBehaviour
{
    [SerializeField] public float currententertaintment;
    [SerializeField] private float maxentertaintment;

    public float remainingentertaintmentpercentage
    {
        get
        {
            return currententertaintment / maxentertaintment;
        }
    }

    public UnityEvent OnEntertaintmentChanged;

    public void entertaintmentreduce(float entertaintmentreduction)
    {
        if (currententertaintment == 0)
        {
            return;
        }
        
        currententertaintment -= entertaintmentreduction;
        OnEntertaintmentChanged.Invoke();

        if (currententertaintment < 0)
        {
            currententertaintment = 0;
        }

    }

    public void entertaintmentincrease(float EntertaintmentToAdd)
    {
        if (currententertaintment == maxentertaintment)
        {
            return;
        }
        currententertaintment += EntertaintmentToAdd;
        
        if (currententertaintment > maxentertaintment)
        {
            currententertaintment = maxentertaintment;
        }
        OnEntertaintmentChanged.Invoke();
    }
}
