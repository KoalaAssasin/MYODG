using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeClicks1 : MonoBehaviour
{
    public Button button;
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

        if (Input.GetMouseButtonUp(0) && button.points > 29)
        {
            button.points -= 30;
            button.pointText.text = button.points.ToString();

            button.pointIncrease += 1;

            this.gameObject.SetActive(false);
        }
    }
}
