using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FloorManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject losePanel;
    void Start()
    {
        losePanel.SetActive(false);
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player") // eğer çarpan nesne player yeni biz isek bizi yok ediyoruz.
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
            
        }

    }

    public void replayButton()
    {
        SceneManager.LoadScene("Game 01");
    }
    public void menuButton()
    {
        SceneManager.LoadScene("Menu");
    }


}
