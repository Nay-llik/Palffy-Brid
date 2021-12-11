using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //ecrans du jeu
    public GameObject start_panel;
    public GameObject gameOverPanel;

    void Start()
    {
        //lance ecran start desactive game over
        gameOverPanel.gameObject.SetActive(false);
        start_panel.gameObject.SetActive(true);
    }

    public void triggerGameOver()
    {
        //lance game over
        gameOverPanel.gameObject.SetActive(true);
    }
}
