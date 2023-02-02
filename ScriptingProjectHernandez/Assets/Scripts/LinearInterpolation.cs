using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{  /*
    // In this cae, result = 4
    float result = Mathf.Lerp(3f, 5f, 0.5f);
    // The Mathf.Lerp function takes 3 float parameters: one representing the value to interpolate from;; another respresenting how far to interpolate.

    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);

    // Here result = (4, 5, 6)
    Vector3 result = Vector3.Lerp (from, to, 0.75f);
    // Vector3 works the same as mathf.lerp, but the from and to values are of type Vector3


    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
        //This changes the light intensity to different values, so after each frame the light intensity increases but slows down as it reaches 8.

        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
        //instead of changing the intensity per frame,, this code changes the intensity per second.
    }
    */
}
