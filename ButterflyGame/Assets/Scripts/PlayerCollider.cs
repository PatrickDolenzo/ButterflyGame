using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    public Sprite Yellow;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("We just collided from player");
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Yellow;


    }
}
