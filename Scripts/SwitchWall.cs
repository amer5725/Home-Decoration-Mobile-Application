using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWall : MonoBehaviour
{
    public GameObject wall1, wall2, wall3, wall4, wall5, wall6;
    int whichObjectIsOn = 1;

    void Start()
    {
        wall1.gameObject.SetActive(true);
        wall2.gameObject.SetActive(false);
        wall3.gameObject.SetActive(false);
        wall4.gameObject.SetActive(false);
        wall5.gameObject.SetActive(false);
        wall6.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                wall1.gameObject.SetActive(false);
                wall2.gameObject.SetActive(true);
                wall3.gameObject.SetActive(false);
                wall4.gameObject.SetActive(false);
                wall5.gameObject.SetActive(false);
                wall6.gameObject.SetActive(false);
                break;

            case 2:      

                whichObjectIsOn = 3;

                wall1.gameObject.SetActive(false);
                wall2.gameObject.SetActive(false);
                wall3.gameObject.SetActive(true);
                wall4.gameObject.SetActive(false);
                wall5.gameObject.SetActive(false);
                wall6.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                wall1.gameObject.SetActive(false);
                wall2.gameObject.SetActive(false);
                wall3.gameObject.SetActive(false);
                wall4.gameObject.SetActive(true);
                wall5.gameObject.SetActive(false);
                wall6.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                wall1.gameObject.SetActive(false);
                wall2.gameObject.SetActive(false);
                wall3.gameObject.SetActive(false);
                wall4.gameObject.SetActive(false);
                wall5.gameObject.SetActive(true);
                wall6.gameObject.SetActive(false);
                break;

            case 5:

                whichObjectIsOn = 6;

                wall1.gameObject.SetActive(false);
                wall2.gameObject.SetActive(false);
                wall3.gameObject.SetActive(false);
                wall4.gameObject.SetActive(false);
                wall5.gameObject.SetActive(false);
                wall6.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                wall1.gameObject.SetActive(true);
                wall2.gameObject.SetActive(false);
                wall3.gameObject.SetActive(false);
                wall4.gameObject.SetActive(false);
                wall5.gameObject.SetActive(false);
                wall6.gameObject.SetActive(false);
                break;


        }
    }
}