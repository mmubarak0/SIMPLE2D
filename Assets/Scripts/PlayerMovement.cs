using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;
    float h;
    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(h, 0f, 0f);
    }
}
