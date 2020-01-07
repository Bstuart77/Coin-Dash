using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ultimate : MonoBehaviour
{
    public Text txt;
    public static int ult;
    public ParticleSystem particles;


    private void Start()
    {
        float axis = Input.GetAxis("Horizontal");
    }
    private void Update()
    {
        txt.text = ult.ToString();

        if (ult >= 100)
        {
            ult = 100;
        }
        if (Input.GetKeyDown(KeyCode.Space) && (ult==100)){
    
            ult = 0;
        }
    }
}
