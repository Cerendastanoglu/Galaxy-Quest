using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    
    GameManager gm;

    public int nextLevel;

    void OnTriggerEnter2D(Collider2D collider)
    {
        gm.LoadNextLevel(nextLevel);
    }

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
