using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAstroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start () 
    {
        screenBounds = Camera.main.transform.position;
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector3(screenBounds.y * -2, Random.Range(-screenBounds.x, screenBounds.y));
    }

    IEnumerator asteroidWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
