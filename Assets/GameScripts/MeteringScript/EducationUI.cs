using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EducationUI : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image educationforegroundimages;
    public void UpdateEducationBar(EducationManager EducationManager)
    {
        educationforegroundimages.fillAmount = EducationManager.remainingeducationpercentage;
    }
}
