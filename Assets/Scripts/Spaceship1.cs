using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship1 : MonoBehaviour
{

    public float speed = 2f;
    public Camera cam;
    public GameObject bulletPrefab;
    public Transform player;
    public Rigidbody2D rb;

    [SerializeField] 
    private string loadScene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,speed * Time.deltaTime, 0f);
        
        Camera.main.transform.Translate(speed * Time.deltaTime, 0f, 0f);

        if(Input.GetKey("d"))
        transform.Translate(0f, +speed * Time.deltaTime, 0f);

        if(Input.GetKey("a"))
        transform.Translate(0f, -speed * Time.deltaTime, 0f);

        if(Input.GetKey("w"))
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);

        if(Input.GetKey("s"))
        transform.Translate(+speed * Time.deltaTime, 0f, 0f);

        if(Input.GetKey("space")){
            shootBullet();
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
        SceneManager.LoadScene(loadScene);
    }

    public void shootBullet(){
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;

    }

}

