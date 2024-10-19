using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoClicks : MonoBehaviour
{
    public float AutoclickTimer = 0f;
    public float AutoclickTimer_Thresh;
    public int AutoclickAmount;

    public Button button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AutoclickAmount = 0;
        AutoclickTimer_Thresh = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        AutoclickTimer += Time.deltaTime;

        if (AutoclickTimer > AutoclickTimer_Thresh)
        {
            button.points += AutoclickAmount;
            button.pointText.text = button.points.ToString();
            AutoclickTimer = 0f;
        }
    }
}
