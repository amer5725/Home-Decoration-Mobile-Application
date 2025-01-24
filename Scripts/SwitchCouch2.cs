using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCouch2 : MonoBehaviour
{
    public GameObject couchRight1, couchRight2, couchRight3, couchRight4, couchRight5;
    int whichObjectIsOn = 1;

    void Start()
    {
        couchRight1.gameObject.SetActive(true);
        couchRight2.gameObject.SetActive(false);
        couchRight3.gameObject.SetActive(false);
        couchRight4.gameObject.SetActive(false);
        couchRight5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                couchRight1.gameObject.SetActive(false);
                couchRight2.gameObject.SetActive(true);
                couchRight3.gameObject.SetActive(false);
                couchRight4.gameObject.SetActive(false);
                couchRight5.gameObject.SetActive(false);
                break;

            case 2:

                whichObjectIsOn = 3;

                couchRight1.gameObject.SetActive(false);
                couchRight2.gameObject.SetActive(false);
                couchRight3.gameObject.SetActive(true);
                couchRight4.gameObject.SetActive(false);
                couchRight5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                couchRight1.gameObject.SetActive(false);
                couchRight2.gameObject.SetActive(false);
                couchRight3.gameObject.SetActive(false);
                couchRight4.gameObject.SetActive(true);
                couchRight5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                couchRight1.gameObject.SetActive(false);
                couchRight2.gameObject.SetActive(false);
                couchRight3.gameObject.SetActive(false);
                couchRight4.gameObject.SetActive(false);
                couchRight5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                couchRight1.gameObject.SetActive(true);
                couchRight2.gameObject.SetActive(false);
                couchRight3.gameObject.SetActive(false);
                couchRight4.gameObject.SetActive(false);
                couchRight5.gameObject.SetActive(false);
                break;


        }
    }
}
