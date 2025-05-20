using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firball_fall : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.up*(-10);
    }
}
