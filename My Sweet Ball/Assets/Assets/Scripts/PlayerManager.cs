using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float run;
    public Rigidbody rb;
    public Joystick joystick;
    private float horizontalAxis;
    private float verticalAxis;


    void Start()
    {
        run = PlayerPrefs.GetInt("speed"); //hızımız
    }


    void Update()
    {
        //PlayerPrefs.DeleteKey("firstPlay");
        horizontalAxis = joystick.Horizontal;
        verticalAxis = joystick.Vertical;
        rb.velocity = new Vector3(horizontalAxis * run * Time.deltaTime, rb.velocity.y);
        rb.velocity = new Vector3(rb.velocity.x, -1, verticalAxis * run * Time.deltaTime);

    }
}