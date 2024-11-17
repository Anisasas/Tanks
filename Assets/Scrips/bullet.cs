using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public float liftime = 2f;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Start()
    {
        Destroy(gameObject, liftime);
        
    }

    void Shoot()
    {
        
        Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
    }
    
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
