using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCarpet : MonoBehaviour
{
    public GameObject carpet1, carpet2, carpet3, carpet4, carpet5;
    int whichObjectIsOn = 1;

    void Start()
    {
        carpet1.gameObject.SetActive(true);
        carpet2.gameObject.SetActive(false);
        carpet3.gameObject.SetActive(false);
        carpet4.gameObject.SetActive(false);
        carpet5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                carpet1.gameObject.SetActive(false);
                carpet2.gameObject.SetActive(true);
                carpet3.gameObject.SetActive(false);
                carpet4.gameObject.SetActive(false);
                carpet5.gameObject.SetActive(false);
                break;

            case 2:      

                whichObjectIsOn = 3;

                carpet1.gameObject.SetActive(false);
                carpet2.gameObject.SetActive(false);
                carpet3.gameObject.SetActive(true);
                carpet4.gameObject.SetActive(false);
                carpet5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                carpet1.gameObject.SetActive(false);
                carpet2.gameObject.SetActive(false);
                carpet3.gameObject.SetActive(false);
                carpet4.gameObject.SetActive(true);
                carpet5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                carpet1.gameObject.SetActive(false);
                carpet2.gameObject.SetActive(false);
                carpet3.gameObject.SetActive(false);
                carpet4.gameObject.SetActive(false);
                carpet5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                carpet1.gameObject.SetActive(true);
                carpet2.gameObject.SetActive(false);
                carpet3.gameObject.SetActive(false);
                carpet4.gameObject.SetActive(false);
                carpet5.gameObject.SetActive(false);
                break;


        }
    }
}