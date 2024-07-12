using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerInputHandle InputHandle;

    private BoxCollider2D hitbox;
    private Rigidbody2D rb;

    private float moveX;
    private float moveY;
    private float speed = 1000;


    private void GetPlayerComponents()
    {
        hitbox = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        GetPlayerComponents();

    }

    private void Start()
    {

    }

    private void Update()
    {
        moveX = InputHandle.MoveInput.x;
        moveY = InputHandle.MoveInput.y;

        Vector2 move = new Vector2(moveX, moveY).normalized;

        if (moveX != 0 || moveY != 0)
        {
            rb.AddForce(speed * Time.deltaTime * move);
        }
        else rb.velocity = Vector2.zero;
    }

}
