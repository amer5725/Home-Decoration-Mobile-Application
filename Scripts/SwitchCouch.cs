using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCouch : MonoBehaviour
{
    public GameObject couch1, couch2, couch3, couch4, couch5;
    int whichObjectIsOn = 1;

    void Start()
    {
        couch1.gameObject.SetActive(true);
        couch2.gameObject.SetActive(false);
        couch3.gameObject.SetActive(false);
        couch4.gameObject.SetActive(false);
        couch5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                couch1.gameObject.SetActive(false);
                couch2.gameObject.SetActive(true);
                couch3.gameObject.SetActive(false);
                couch4.gameObject.SetActive(false);
                couch5.gameObject.SetActive(false);
                break;

            case 2:      

                whichObjectIsOn = 3;

                couch1.gameObject.SetActive(false);
                couch2.gameObject.SetActive(false);
                couch3.gameObject.SetActive(true);
                couch4.gameObject.SetActive(false);
                couch5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                couch1.gameObject.SetActive(false);
                couch2.gameObject.SetActive(false);
                couch3.gameObject.SetActive(false);
                couch4.gameObject.SetActive(true);
                couch5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                couch1.gameObject.SetActive(false);
                couch2.gameObject.SetActive(false);
                couch3.gameObject.SetActive(false);
                couch4.gameObject.SetActive(false);
                couch5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                couch1.gameObject.SetActive(true);
                couch2.gameObject.SetActive(false);
                couch3.gameObject.SetActive(false);
                couch4.gameObject.SetActive(false);
                couch5.gameObject.SetActive(false);
                break;


        }
    }
}
