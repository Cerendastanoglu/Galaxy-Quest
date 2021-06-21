using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Transform player;
    public GameObject bulletPrefab;
    public float speed = 2f;
    public Camera cam;
    public Rigidbody2D rb;
    float Horizontal = Input.GetAxis("Horizontal");

    // Update is called once per frame
    void Update(){

        transform.Translate(0f,speed * Time.deltaTime, 0f);
        
        Camera.main.transform.Translate(speed * Time.deltaTime, 0f, 0f);

        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if(Input.GetKeyDown("space")){
            shootBullet();
        }
    }

    void moveCharacter(Vector2 direction){
        player.Translate(direction * speed * Time.deltaTime);
    }
    public void shootBullet(){

        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;
        rb.velocity = transform.right * (Horizontal * speed);
    }
}
