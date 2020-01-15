using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTarget : MonoBehaviour
{
    private void OnMouseUp()
    {
        KeepScore.Score += 5;
        Destroy(gameObject);
    }
    private void Update()
    {
        if(gameObject.name == "target(Clone)")
        {
            Destroy(gameObject, 1f);
        }
    }
}
