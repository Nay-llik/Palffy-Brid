using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public float Speed;
    public Vector3 initialPosition;
    void Start()
    {
        transform.position -= Vector3.right * Speed;
    }
    void Update()
    {
        transform.position -= Vector3.right * Speed;
    }
    private void OnTriggerEnter2D(Collider2D personnage_coll)
    { 
        if (personnage_coll.GetComponent<Player>() != null)
        {
            FindObjectOfType<Score>().addScore();
        }
    }
    public void relaunchObject()
    {
        transform.position = initialPosition;
    }
}
