using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class MenuHighScore : MonoBehaviour
{
    public TMP_Text HighScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        string Path = Application.persistentDataPath + "/HighScore.txt";
        bool FileExists = File.Exists(Path);
        if (!FileExists)
        {
            File.WriteAllText(Path, "0");
        }
        //Pass the file path and file name to the StreamReader constructor
        // StreamReader ScoreText = new StreamReader(Application.persistentDataPath + "/HighScore.txt");
        //Read the first line of text
        string Score = File.ReadAllText(Path);
        HighScoreDisplay.SetText("High Score: " + Score);
    }
}
