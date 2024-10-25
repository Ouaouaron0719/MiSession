using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]public float speed = 5f;       
    [SerializeField] public float swimSpeed = 3f;   
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (move > 0)
        {
            spriteRenderer.flipX = false;  
        }
        else if (move < 0)
        {
            spriteRenderer.flipX = true;  
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, swimSpeed);
        }
    }
}
