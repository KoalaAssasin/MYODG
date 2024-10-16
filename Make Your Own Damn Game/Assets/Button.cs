using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{

    public int points = 0;
    public Animator anim;
    public TMP_Text pointText;
    public GameObject purchaseUIBox;
    public PurchaseUIButton PUIB;

    bool purchaseUIBoxActivated = false;

    void Start()
    {
        purchaseUIBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (points >= 10 && purchaseUIBoxActivated == false)
        {
            purchaseUIBox.SetActive(true);
            purchaseUIBoxActivated = true;
        }


    }
    void OnMouseOver()
    {

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("ButtonPressed", true);
            points++;
            pointText.text = points.ToString();

            StartCoroutine(ExecuteAfterTime(0.01f));
        }

    }

    //plays button animation 1 time (clunky)
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        anim.SetBool("ButtonPressed", false);
    }
}
