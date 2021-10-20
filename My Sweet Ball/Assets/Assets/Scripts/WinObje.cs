using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinObje : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject winPanel;
    int levelNum;
    void Start()
    {
        levelNum= PlayerPrefs.GetInt("levelNum");
        winPanel.SetActive(false);
        Time.timeScale = 1;
    }


    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            levelNum++;
            PlayerPrefs.SetInt("levelNum", levelNum);
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void replayButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void menuButton()
    {
        SceneManager.LoadScene("Menu");
    }

}