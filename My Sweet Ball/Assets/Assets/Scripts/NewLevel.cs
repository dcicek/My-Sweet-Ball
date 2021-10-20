using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newLevelButtonClicked()
    {
        if (PlayerPrefs.GetInt("levelNum") == 1)
        {
            PlayerPrefs.SetInt("speed", 1000);
            SceneManager.LoadScene("Game 01");
        }
        else if (PlayerPrefs.GetInt("levelNum") == 2)
        {
            SceneManager.LoadScene("Game 02");
        }
        else if (PlayerPrefs.GetInt("levelNum") == 3)
        {
            PlayerPrefs.SetInt("speed", 2000);
            SceneManager.LoadScene("Game 03");
        }
        else if (PlayerPrefs.GetInt("levelNum") == 4)
        {
            SceneManager.LoadScene("Game 04");
        }
        else if (PlayerPrefs.GetInt("levelNum") == 5)
        {
            PlayerPrefs.SetInt("speed", 2500);
            SceneManager.LoadScene("Game 05");
        }
        else if (PlayerPrefs.GetInt("levelNum") == 6)
        {
            PlayerPrefs.SetInt("speed", 3000);
            SceneManager.LoadScene("Game 06");
        }
        else if (PlayerPrefs.GetInt("levelNum") == 7)
        {
            SceneManager.LoadScene("Game 07");
        }
        else
        {
            SceneManager.LoadScene("Finish");
        }
    }
}
