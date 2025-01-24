using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDesk : MonoBehaviour
{
    public GameObject desk1, desk2, desk3, desk4, desk5;
    int whichObjectIsOn = 1;

    void Start()
    {
        desk1.gameObject.SetActive(true);
        desk2.gameObject.SetActive(false);
        desk3.gameObject.SetActive(false);
        desk4.gameObject.SetActive(false);
        desk5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                desk1.gameObject.SetActive(false);
                desk2.gameObject.SetActive(true);
                desk3.gameObject.SetActive(false);
                desk4.gameObject.SetActive(false);
                desk5.gameObject.SetActive(false);
                break;

            case 2:

                whichObjectIsOn = 3;

                desk1.gameObject.SetActive(false);
                desk2.gameObject.SetActive(false);
                desk3.gameObject.SetActive(true);
                desk4.gameObject.SetActive(false);
                desk5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                desk1.gameObject.SetActive(false);
                desk2.gameObject.SetActive(false);
                desk3.gameObject.SetActive(false);
                desk4.gameObject.SetActive(true);
                desk5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                desk1.gameObject.SetActive(false);
                desk2.gameObject.SetActive(false);
                desk3.gameObject.SetActive(false);
                desk4.gameObject.SetActive(false);
                desk5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                desk1.gameObject.SetActive(true);
                desk2.gameObject.SetActive(false);
                desk3.gameObject.SetActive(false);
                desk4.gameObject.SetActive(false);
                desk5.gameObject.SetActive(false);
                break;


        }
    }
}
