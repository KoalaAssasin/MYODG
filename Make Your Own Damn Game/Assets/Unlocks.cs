using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Unlocks : MonoBehaviour
{

    public GameObject ClickUp1;
    public GameObject AutoUp1;
    public GameObject MoreButtons1;

    bool purchasedUgradesBatch1 = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClickUp1.SetActive(false);
        AutoUp1.SetActive(false);
        MoreButtons1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (purchasedUgradesBatch1 == true)
        {
            ClickUp1.SetActive(true);
            AutoUp1.SetActive(true);
            MoreButtons1.SetActive(true);

            purchasedUgradesBatch1 = false;
        }
    }
    public void FirstUpgradeBatchUnlock()
    {
        purchasedUgradesBatch1 = true;
    }
}
