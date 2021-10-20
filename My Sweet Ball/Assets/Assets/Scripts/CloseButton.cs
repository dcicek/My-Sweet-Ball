using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject howToPlayCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closeCanvas()
    {
        howToPlayCanvas.SetActive(false);
    }

    public void openHowToPlay()
    {
        howToPlayCanvas.SetActive(true);
    }
}
