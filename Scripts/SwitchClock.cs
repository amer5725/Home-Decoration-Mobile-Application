using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchClock : MonoBehaviour
{
    public GameObject clock1, clock2, clock3, clock4;
    int whichObjectIsOn = 1;

    void Start()
    {
        clock1.gameObject.SetActive(true);
        clock2.gameObject.SetActive(false);
        clock3.gameObject.SetActive(false);
        clock4.gameObject.SetActive(false);
        

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                clock1.gameObject.SetActive(false);
                clock2.gameObject.SetActive(true);
                clock3.gameObject.SetActive(false);
                clock4.gameObject.SetActive(false);
                
                break;

            case 2:      

                whichObjectIsOn = 3;

                clock1.gameObject.SetActive(false);
                clock2.gameObject.SetActive(false);
                clock3.gameObject.SetActive(true);
                clock4.gameObject.SetActive(false);
                
                break;

            case 3:

                whichObjectIsOn = 4;

                clock1.gameObject.SetActive(false);
                clock2.gameObject.SetActive(false);
                clock3.gameObject.SetActive(false);
                clock4.gameObject.SetActive(true);
                
                break;

            default:

                whichObjectIsOn = 1;

                clock1.gameObject.SetActive(true);
                clock2.gameObject.SetActive(false);
                clock3.gameObject.SetActive(false);
                clock4.gameObject.SetActive(false);

                break;


        }
    }
}
