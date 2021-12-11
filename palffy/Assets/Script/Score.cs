using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    //on crée une variable score qui s'affiche in game et augmente a chaque fois que le joueur collisionne avec une score count
    public int score =0;
    public void addScore()
    {
        score++;
        GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
