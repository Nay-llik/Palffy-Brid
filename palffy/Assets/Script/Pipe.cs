using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
//deplace les pipes et les renvoie a une nouvelle position lorsque collision avec la teleporter
{
    public float Speed;
    public Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
        this.enabled = false;
    }
    void Update()
    {
        transform.position -= Vector3.right * Speed;
    }
    public void relaunchObject()
    {
        transform.position = initialPosition;
    }
}
