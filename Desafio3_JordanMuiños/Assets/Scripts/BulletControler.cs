using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    public Vector3 bulletDirection;
    public float bulletSpeed;
    public int bulletDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMovement();
    }

    void BulletMovement()
    {
        transform.Translate(bulletDirection * bulletSpeed * Time.deltaTime);

    }
}
