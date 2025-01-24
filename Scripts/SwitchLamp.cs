using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLamp : MonoBehaviour
{
    public GameObject lamp1, lamp2, lamp3, lamp4, lamp5;
    int whichObjectIsOn = 1;

    void Start()
    {
        lamp1.gameObject.SetActive(true);
        lamp2.gameObject.SetActive(false);
        lamp3.gameObject.SetActive(false);
        lamp4.gameObject.SetActive(false);
        lamp5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                lamp1.gameObject.SetActive(false);
                lamp2.gameObject.SetActive(true);
                lamp3.gameObject.SetActive(false);
                lamp4.gameObject.SetActive(false);
                lamp5.gameObject.SetActive(false);
                break;

            case 2:

                whichObjectIsOn = 3;

                lamp1.gameObject.SetActive(false);
                lamp2.gameObject.SetActive(false);
                lamp3.gameObject.SetActive(true);
                lamp4.gameObject.SetActive(false);
                lamp5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                lamp1.gameObject.SetActive(false);
                lamp2.gameObject.SetActive(false);
                lamp3.gameObject.SetActive(false);
                lamp4.gameObject.SetActive(true);
                lamp5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                lamp1.gameObject.SetActive(false);
                lamp2.gameObject.SetActive(false);
                lamp3.gameObject.SetActive(false);
                lamp4.gameObject.SetActive(false);
                lamp5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                lamp1.gameObject.SetActive(true);
                lamp2.gameObject.SetActive(false);
                lamp3.gameObject.SetActive(false);
                lamp4.gameObject.SetActive(false);
                lamp5.gameObject.SetActive(false);
                break;


        }
    }
}
