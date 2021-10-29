using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpaddle : MonoBehaviour
{
    public Vector3 startPos;
    public Rigidbody2D rb;
    public float speed;
    private float movement;

    public bool isPlayerLeft;
    public bool isPlayerRight;
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
    }
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerLeft)
        {
            movement = Input.GetAxisRaw("Vertical L");
        }

        if (isPlayerRight)
        {
            movement = Input.GetAxisRaw("Vertical R");
        }

        rb.velocity = new Vector2(0, movement * speed);
    }
}