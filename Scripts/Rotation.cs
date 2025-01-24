using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [Range(1f, 30f)]
    float smoothTime = 10.0f;
    public float rotationAngle = 90.0f;

    void Start()
    {

    }

 private bool _rotate;
 
 void Update()
 {
     if(_rotate)
     {
            Quaternion desiredRotation = Quaternion.Euler(0, 0, rotationAngle);
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothTime);
     }

 }
 
 public void OnPress()
 {
     _rotate = true;
 }
 
 public void OnRelease()
 {
     _rotate = false;
 }
}

