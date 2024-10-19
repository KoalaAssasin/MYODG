using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UpgradeAuto1 : MonoBehaviour
{
    public Button button;
    public AutoClicks autoClicks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {

        if (Input.GetMouseButtonUp(0) && button.points > 59)
        {
            button.points -= 60;
            button.pointText.text = button.points.ToString();

            autoClicks.AutoclickAmount += 1;

            this.gameObject.SetActive(false);
        }
    }
}
