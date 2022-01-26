using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
   // Before rendering each frame
   void Update ()
    {
        // Rotate pickups by 15 on x axis, 30 on y axis, and 45 in z axis
        // by deltaTime and not by frame
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
