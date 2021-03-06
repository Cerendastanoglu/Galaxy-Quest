using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.transform.position;

    }

    // Update is called once per frame
    void Update () {
        if(transform.position.y < screenBounds.y * 2){
            Destroy(this.gameObject);
        }
    }
}

