using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSticker : MonoBehaviour
{
    public GameObject sticker1, sticker2, sticker3, sticker4, sticker5;
    int whichObjectIsOn = 1;

    void Start()
    {
        sticker1.gameObject.SetActive(true);
        sticker2.gameObject.SetActive(false);
        sticker3.gameObject.SetActive(false);
        sticker4.gameObject.SetActive(false);
        sticker5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                sticker1.gameObject.SetActive(false);
                sticker2.gameObject.SetActive(true);
                sticker3.gameObject.SetActive(false);
                sticker4.gameObject.SetActive(false);
                sticker5.gameObject.SetActive(false);
                break;

            case 2:      

                whichObjectIsOn = 3;

                sticker1.gameObject.SetActive(false);
                sticker2.gameObject.SetActive(false);
                sticker3.gameObject.SetActive(true);
                sticker4.gameObject.SetActive(false);
                sticker5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                sticker1.gameObject.SetActive(false);
                sticker2.gameObject.SetActive(false);
                sticker3.gameObject.SetActive(false);
                sticker4.gameObject.SetActive(true);
                sticker5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                sticker1.gameObject.SetActive(false);
                sticker2.gameObject.SetActive(false);
                sticker3.gameObject.SetActive(false);
                sticker4.gameObject.SetActive(false);
                sticker5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                sticker1.gameObject.SetActive(true);
                sticker2.gameObject.SetActive(false);
                sticker3.gameObject.SetActive(false);
                sticker4.gameObject.SetActive(false);
                sticker5.gameObject.SetActive(false);
                break;


        }
    }
}