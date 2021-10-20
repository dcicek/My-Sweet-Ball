using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - Player.transform.position;
    }

    void Update()
    {
        transform.position = Player.transform.position+ mesafe;
    }
}
