using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchShelves : MonoBehaviour
{
    public GameObject shelves1, shelves2, shelves3, shelves4;
    int whichObjectIsOn = 1;

    void Start()
    {
        shelves1.gameObject.SetActive(true);
        shelves2.gameObject.SetActive(false);
        shelves3.gameObject.SetActive(false);
        shelves4.gameObject.SetActive(false);
        

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                shelves1.gameObject.SetActive(false);
                shelves2.gameObject.SetActive(true);
                shelves3.gameObject.SetActive(false);
                shelves4.gameObject.SetActive(false);
                
                break;

            case 2:      

                whichObjectIsOn = 3;

                shelves1.gameObject.SetActive(false);
                shelves2.gameObject.SetActive(false);
                shelves3.gameObject.SetActive(true);
                shelves4.gameObject.SetActive(false);
                
                break;

            case 3:

                whichObjectIsOn = 4;

                shelves1.gameObject.SetActive(false);
                shelves2.gameObject.SetActive(false);
                shelves3.gameObject.SetActive(false);
                shelves4.gameObject.SetActive(true);
                
                break;

            default:

                whichObjectIsOn = 1;

                shelves1.gameObject.SetActive(true);
                shelves2.gameObject.SetActive(false);
                shelves3.gameObject.SetActive(false);
                shelves4.gameObject.SetActive(false);

                break;


        }
    }
}
