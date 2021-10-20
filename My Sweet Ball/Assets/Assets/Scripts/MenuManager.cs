using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BaslaButton()
    {
        if(PlayerPrefs.GetInt("firstPlay",0) == 0)
        {
            PlayerPrefs.SetInt("firstPlay", 1);
            PlayerPrefs.SetInt("levelNum", 1);
            PlayerPrefs.SetInt("speed", 1000);
            SceneManager.LoadScene("Game 01");
        }
        else
        {
            if(PlayerPrefs.GetInt("levelNum")==1)
            {
                SceneManager.LoadScene("Game 01");
                PlayerPrefs.SetInt("speed", 1000);
            }
            else if (PlayerPrefs.GetInt("levelNum") == 2)
            {
                SceneManager.LoadScene("Game 02");
                PlayerPrefs.SetInt("speed", 1000);
            }
            else if (PlayerPrefs.GetInt("levelNum") == 3)
            {
                SceneManager.LoadScene("Game 03");
                PlayerPrefs.SetInt("speed", 2000);
            }
            else if (PlayerPrefs.GetInt("levelNum") == 4)
            {
                SceneManager.LoadScene("Game 04");
                PlayerPrefs.SetInt("speed", 2000);
            }
            else if (PlayerPrefs.GetInt("levelNum") == 5)
            {
                SceneManager.LoadScene("Game 05");
                PlayerPrefs.SetInt("speed", 2500);
            }
            else if (PlayerPrefs.GetInt("levelNum") == 6)
            {
                SceneManager.LoadScene("Game 06");
                PlayerPrefs.SetInt("speed", 3000);
            }
            else if (PlayerPrefs.GetInt("levelNum") == 7)
            {
                SceneManager.LoadScene("Game 07");
                PlayerPrefs.SetInt("speed", 3000);
            }
        }
            
        
    }

    public void CikisButton()
    {
        Application.Quit();
    }
}
