using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

// rename this class to suit your needs
public class TestIntanstiation : MonoBehaviour
{
    // the Equip prefab - required for instantiation
    public GameObject equip;
    
    // list that holds all created objects - deleate all instances if desired
    public List<GameObject> createdObjects = new List<GameObject>();

    private float minX, maxX, minY, maxY;

   /* void Start()
    {
        // get the screen bounds
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0,0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1,1, camDistance));

        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;
    }*/

    public void CreateObject()
    {
        // a prefab is need to perform the instantiation
        if (equip != null)
        {
            // get a random postion to instantiate the prefab - you can change this to be created at a fied point if desired
            Vector3 position = new Vector3(Random.Range(minX + 0.5f, maxX - 0.5f), Random.Range(minY + 0.5f, maxY - 0.5f), 0);

            // instantiate the object
            GameObject go = (GameObject)Instantiate(equip, position, Quaternion.identity);
            createdObjects.Add(go);
        }
    }    
}
