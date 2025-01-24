using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAccessories : MonoBehaviour
{
    public GameObject accessories1, accessories2, accessories3, accessories4, accessories5;
    int whichObjectIsOn = 1;

    void Start()
    {
        accessories1.gameObject.SetActive(true);
        accessories2.gameObject.SetActive(false);
        accessories3.gameObject.SetActive(false);
        accessories4.gameObject.SetActive(false);
        accessories5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                accessories1.gameObject.SetActive(false);
                accessories2.gameObject.SetActive(true);
                accessories3.gameObject.SetActive(false);
                accessories4.gameObject.SetActive(false);
                accessories5.gameObject.SetActive(false);
                break;

            case 2:      

                whichObjectIsOn = 3;

                accessories1.gameObject.SetActive(false);
                accessories2.gameObject.SetActive(false);
                accessories3.gameObject.SetActive(true);
                accessories4.gameObject.SetActive(false);
                accessories5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                accessories1.gameObject.SetActive(false);
                accessories2.gameObject.SetActive(false);
                accessories3.gameObject.SetActive(false);
                accessories4.gameObject.SetActive(true);
                accessories5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                accessories1.gameObject.SetActive(false);
                accessories2.gameObject.SetActive(false);
                accessories3.gameObject.SetActive(false);
                accessories4.gameObject.SetActive(false);
                accessories5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                accessories1.gameObject.SetActive(true);
                accessories2.gameObject.SetActive(false);
                accessories3.gameObject.SetActive(false);
                accessories4.gameObject.SetActive(false);
                accessories5.gameObject.SetActive(false);
                break;


        }
    }
}