using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetName : MonoBehaviour
{
    public static string name;
    public GameObject inputField;
    public GameObject textDisplay;

    public void SaveName()
    {   
        name = inputField.GetComponent<Text>().text;
        print(textDisplay.GetComponent<Text>().text = " Welcome " + name + " to the game");
    }

}
