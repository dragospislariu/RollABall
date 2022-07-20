using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 10;
    public bool isMovingRight = false;
    public float limitRight = 79;
    public float limitLeft = 65;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    private void Move()
    {
        if (!isMovingRight)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


        if (transform.position.x < limitLeft)
        {
            isMovingRight = true;
        }

        if (transform.position.x > limitRight)
        {

            isMovingRight = false;
        }
    }
}
