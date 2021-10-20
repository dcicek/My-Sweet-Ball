using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject losePanel;
    void Start()
    {
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
}
