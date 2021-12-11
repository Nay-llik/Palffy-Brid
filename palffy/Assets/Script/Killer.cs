using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    //lance la scene de mort lorsque bird coll avec pipe
    private void OnTriggerEnter2D(Collider2D personnege_coll)
    {
        if (personnege_coll.GetComponent<Player>()!=null)
        {
            FindObjectOfType<UIManager>().triggerGameOver();
        }
    }
}
