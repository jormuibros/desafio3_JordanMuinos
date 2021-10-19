using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    //public GameObject BulletPrefab;
    public GameObject[] BulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnBullet();
        InvokeRepeating("SpawnBullet", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnBullet()
    {
        
        //Instantiate(BulletPrefab, transform);
        int enemyIndex = Random.Range(0, BulletPrefab.Length);
        Instantiate(BulletPrefab[enemyIndex], transform);
    }
}
