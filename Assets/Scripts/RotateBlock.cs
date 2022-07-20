using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlock : MonoBehaviour
{
    public float rotSpeed = 50;

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, rotSpeed, 0) * Time.deltaTime);
    }
}
