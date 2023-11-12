using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class ScoreHandler : MonoBehaviour
{
    public TextAsset HighScoreString;
    public TMP_Text ScoreString;
    int HighScore;

    private void Start()
    {
        HighScore = int.Parse(HighScoreString.text);
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreCollider")
        {
            Destroy(collision.gameObject);
            ScoreString.SetText(AddScore());
        }
    }

    private string AddScore()
    {
        int Score = int.Parse(ScoreString.text);
        Score++;

        if (Score > HighScore)
        {
            string path = Application.persistentDataPath + "/HighScore.txt";
            StreamWriter writer = new StreamWriter(path, false);
            writer.WriteLine(Score.ToString());
            writer.Close();
        }

        return Score.ToString(); 
    }


}
