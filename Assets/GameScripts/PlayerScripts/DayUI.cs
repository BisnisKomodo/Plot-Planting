using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayUI : MonoBehaviour
{
    public TMP_Text daytext;
    public static int Currentday { get; private set; }
    void Start()
    {
        Currentday = 1;
        UpdateDayUI();
    }

    public void NextDay()
    {
        Currentday++;
        UpdateDayUI();
    }

    void UpdateDayUI()
    {
        daytext.text = "Day : " + Currentday.ToString();
    }
}
