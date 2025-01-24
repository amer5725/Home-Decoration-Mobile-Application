using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFrame3D : MonoBehaviour
{
    public GameObject frame3D1, frame3D2, frame3D3;
    int whichObjectIsOn = 1;

    void Start()
    {
        frame3D1.gameObject.SetActive(true);
        frame3D2.gameObject.SetActive(false);
        frame3D3.gameObject.SetActive(false);
               

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                frame3D1.gameObject.SetActive(false);
                frame3D2.gameObject.SetActive(true);
                frame3D3.gameObject.SetActive(false);
                
                
                break;

            case 2:      

                whichObjectIsOn = 3;

                frame3D1.gameObject.SetActive(false);
                frame3D2.gameObject.SetActive(false);
                frame3D3.gameObject.SetActive(true);
                
                
                break;

            default:

                whichObjectIsOn = 1;

                frame3D1.gameObject.SetActive(true);
                frame3D2.gameObject.SetActive(false);
                frame3D3.gameObject.SetActive(false);
                

                break;


        }
    }
}
