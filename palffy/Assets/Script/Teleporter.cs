using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D personnage_coll)
    {
        //teleporte les pipe qui ont passé l'écran
        if (personnage_coll.GetComponent<Pipe>()!=null || personnage_coll.GetComponent<Checkpoint>() != null)
        {
            personnage_coll.transform.position = new Vector3(7f, personnage_coll.transform.position.y, 0f);
        }
    }
}

