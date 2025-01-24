using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addDestroy : MonoBehaviour
{
    public GameObject spawnPrefab;
    private Vector2 screenBounds;
    private bool spawn;

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        { 
            GameObject a = Instantiate(spawnPrefab) as GameObject;
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            a.transform.position = new Vector2(screenBounds.x, screenBounds.y);
        }
    }
    public void OnPress()
    {
        spawn = true;
    }

    public void OnRelease()
    {
        spawn = false;
    }
}