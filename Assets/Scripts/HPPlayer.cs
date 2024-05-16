using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPlayer : MonoBehaviour
{
    [SerializeField] int HP = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "HP")
        {
            FindAnyObjectByType<Game_Session>().AddHP(HP);
            Destroy(collision.gameObject);
        }
    }
}
