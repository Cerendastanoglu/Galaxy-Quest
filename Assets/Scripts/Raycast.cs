using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    AudioSource audiosource;
    private Vector3 _horizontalMovement;
    public float damage = 10f;
    public ParticleSystem impact;
    public GameObject player;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        _horizontalMovement = new Vector3(0f, 0f, -Input.GetAxis("Horizontal"));
       

        if(Input.GetKey(KeyCode.Space))
        {
            Debug.DrawLine(player.transform.position, transform.TransformDirection(Vector2.up) * 10f, Color.red, 0.5f);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);

            if(hit)
            {
                impact.Play();
                Destroy(hit.collider.gameObject);
                Debug.Log("Hit Something : "+ hit.collider.name);
                audiosource.Play();


            }
        }
        else
        {
            Debug.DrawLine(player.transform.position, transform.TransformDirection(Vector2.up) * 10f, Color.green, 0.5f);
        }


    }
}
