using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float rotSpeed = 50;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(rotSpeed, 0, 0) * Time.deltaTime);
    }
}

