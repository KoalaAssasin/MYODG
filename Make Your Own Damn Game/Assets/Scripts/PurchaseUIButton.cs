using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseUIButton : MonoBehaviour
{
    public Button button;
    public Unlocks unlocks;
    public GameObject UIElements;

    bool purchaseUIActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        //UIElements.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseOver()
    {

        if (Input.GetMouseButtonUp(0) && button.points > 19 && purchaseUIActivated == false)
        {
            button.points -= 20;
            button.pointText.text = button.points.ToString();
            purchaseUIActivated = true;

            UIElements.SetActive(true);
            button.purchaseUIBox.SetActive(false);

            Unlocks instance = unlocks.GetComponent<Unlocks>();
            instance.FirstUpgradeBatchUnlock();
        }
    }
}
