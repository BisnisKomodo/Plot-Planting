using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics.Tracing;

public class DayManager : MonoBehaviour
{
    
    public int currentDay = 1;
    public TMP_Text dayText;
    public GameObject[] eventpanels;
    void Start()
    {
        UpdateDayUI();
        HideAllEventPanels();
    }

    public void ProgressDay()
    {
        currentDay++; 
        UpdateDayUI();

        TriggerRandomEvent();
    }

    void UpdateDayUI()
    {
        dayText.text = "Day : " + currentDay.ToString();
    }

    private void TriggerRandomEvent()
    {
        int RandomIndex = Random.Range(0, eventpanels.Length);
        GameObject selectedEvents = eventpanels[RandomIndex];
        Debug.Log("Triggering Events");
        selectedEvents.SetActive(true);
    }

    private void HideAllEventPanels()
    {
        foreach (GameObject panel in eventpanels)
        {
            panel.SetActive(false);
        }
    }
}

