using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 30.0f;
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal") * velocity;
        float v = Input.GetAxisRaw("Vertical" ) * velocity;
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            GameManager.Instance.Respawn();
        }
    }
}
