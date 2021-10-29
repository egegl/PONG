using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPos;

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
        Launch();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (DifficultySelect.difficultyvalue == 2)
        {
            speed = 5;
        }
        else if (DifficultySelect.difficultyvalue == 3)
        {
            speed = 7;
        }
        else if (DifficultySelect.difficultyvalue == 4)
        {
            speed = 9;
        }
        else
        {
            speed = 4;
        }
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
