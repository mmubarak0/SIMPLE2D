using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /* Simple movement script 
        << short description >>
    */
    public float speed = 50f;
    float h, v;

    void Update()
    {
        h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        v = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(h, v); // we don't change z in 2D games. it's used to sort objects
    }
}
