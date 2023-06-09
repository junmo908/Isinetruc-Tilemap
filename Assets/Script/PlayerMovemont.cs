using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemont : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    private PlayerAnimation playerAnimation;
    public float moveSpeed = 1.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = FindObjectOfType<PlayerAnimation>();
    }

    private void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 currentPos = rb.position;
        Vector2 inputVector = new Vector2(moveH, moveV).normalized * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(currentPos + inputVector);

        playerAnimation.SetDirection(new Vector2(moveH, moveV));
    }

}
