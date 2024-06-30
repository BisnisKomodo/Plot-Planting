using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EducationManager : MonoBehaviour
{
    [SerializeField] public float currenteducation;
    [SerializeField] private float maxeducation;

    public float remainingeducationpercentage
    {
        get
        {
            return currenteducation / maxeducation;
        }
    }

    public UnityEvent OnEducationChanged;

    public void educationreduce(float educationreduction)
    {
        if (currenteducation == 0)
        {
            return;
        }
        currenteducation -= educationreduction;
        OnEducationChanged.Invoke();

        if (currenteducation < 0)
        {
            currenteducation = 0;
        }
    }

    public void educationincrease(float educationadd)
    {
        if (currenteducation == maxeducation)
        {
            return;
        }

        currenteducation += educationadd;
        if (currenteducation > maxeducation)
        {
            currenteducation = maxeducation;
        }

        OnEducationChanged.Invoke();
    }
}
