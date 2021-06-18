using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public Camera cam;
    public float speed = 0.1f;
    public Rigidbody2D rb;

    Vector2 mousePos;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);

        Camera.main.transform.Translate(0f, speed * Time.deltaTime, 0f);

        

        if(Input.GetKey("up"))
        transform.Translate(0f, +speed * Time.deltaTime, 0f);

        if(Input.GetKey("down"))
        transform.Translate(0f, -speed * Time.deltaTime, 0f);

        if(Input.GetKey("left"))
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);

        if(Input.GetKey("right"))
        transform.Translate(+speed * Time.deltaTime, 0f, 0f);

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}

