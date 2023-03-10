using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerID;
    public float racketSpeed;

    private Rigidbody2D rb;
    private Vector2 racketDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerID == 1)
        {
            float directionY = Input.GetAxisRaw("Vertical2");

            racketDirection = new Vector2(0, directionY).normalized;


        }else if (playerID == 0)
        {
            float directionY = Input.GetAxisRaw("Vertical");
            racketDirection = new Vector2(0, directionY).normalized;

        }
    }

    private void FixedUpdate()
    {
        rb.velocity = racketDirection * racketSpeed;
    }
}
