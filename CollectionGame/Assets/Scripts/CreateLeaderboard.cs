using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class CreateLeaderboard : MonoBehaviour
{

    void createFile()
    {
        string file = Application.dataPath + "/LeaderBoard.txt";

        if (!File.Exists(file))
        {
            File.Create(file);
            readFile();
            writeToFile();
        }
    }

    void readFile()
    {
        string file = Application.dataPath + "/LeaderBoard.txt";

        StreamReader input = new StreamReader(file);

        while (input.EndOfStream)
        {
            string inputLine = input.ReadLine().Substring(1,2);
        } 
    }   
    void writeToFile()
    {
        string file = Application.dataPath + "/LeaderBoard.txt";
        StreamWriter writer = new StreamWriter(file, true);

        writer.WriteLine(KeepScore.Score);
        writer.Close();
    }
}
