using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    public int Ponts = 0;
    public string logros;

    public TMP_Text PointsText;
    public TMP_Text LogrosText;
    void Start()
    {
        PointsText = PlayerPrefs.GetInt("Points");
        logros = PlayerPrefs.GetString("Logros");
        PointsText.text - PointsText.ToString();
        LogrosText.text = logros;
    }

   
    void Update()
    {
        
    }
}
