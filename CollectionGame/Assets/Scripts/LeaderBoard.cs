using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : MonoBehaviour
{
    string name;
    int score;

    public LeaderBoard(string name, int score)
    {
        this.name = name;
        this.score = score;
    }

       
}
