using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTv : MonoBehaviour
{
    public GameObject tv1, tv2, tv3, tv4, tv5;
    int whichObjectIsOn = 1;

    void Start()
    {
        tv1.gameObject.SetActive(true);
        tv2.gameObject.SetActive(false);
        tv3.gameObject.SetActive(false);
        tv4.gameObject.SetActive(false);
        tv5.gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void Switch()
    {
        switch (whichObjectIsOn)
        {
            case 1:

                whichObjectIsOn = 2;

                tv1.gameObject.SetActive(false);
                tv2.gameObject.SetActive(true);
                tv3.gameObject.SetActive(false);
                tv4.gameObject.SetActive(false);
                tv5.gameObject.SetActive(false);
                break;

            case 2:

                whichObjectIsOn = 3;

                tv1.gameObject.SetActive(false);
                tv2.gameObject.SetActive(false);
                tv3.gameObject.SetActive(true);
                tv4.gameObject.SetActive(false);
                tv5.gameObject.SetActive(false);
                break;

            case 3:

                whichObjectIsOn = 4;

                tv1.gameObject.SetActive(false);
                tv2.gameObject.SetActive(false);
                tv3.gameObject.SetActive(false);
                tv4.gameObject.SetActive(true);
                tv5.gameObject.SetActive(false);
                break;

            case 4:

                whichObjectIsOn = 5;

                tv1.gameObject.SetActive(false);
                tv2.gameObject.SetActive(false);
                tv3.gameObject.SetActive(false);
                tv4.gameObject.SetActive(false);
                tv5.gameObject.SetActive(true);
                break;

            default:

                whichObjectIsOn = 1;

                tv1.gameObject.SetActive(true);
                tv2.gameObject.SetActive(false);
                tv3.gameObject.SetActive(false);
                tv4.gameObject.SetActive(false);
                tv5.gameObject.SetActive(false);
                break;


        }
    }
}
