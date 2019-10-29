using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotation : MonoBehaviour
{
  
    
   
    void Update()
    {
        transform.Rotate(90f * Time.deltaTime, 0, 0);
    }
}
