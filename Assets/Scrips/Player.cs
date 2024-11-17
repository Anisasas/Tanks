using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1 = true;
    [Header("Movement")]
    public float speed = 10.0f;
    public float fireRate = 0.5f;

    void Start()
    {
        InvokeRepeating("Shoot", 0.0f, fireRate);
    }

    void Update()
    {
        var input = new Vector3();
        if (isPlayer1)
        {
            input.x = Input.GetAxis("HorizontalKys");
            input.z = Input.GetAxis("VerticalKys");
        }
        else
        {
            input.x = Input.GetAxis("HorizontalArows");
            input.z = Input.GetAxis("VerticalArows");
        }

        transform.position += input * speed * Time.deltaTime;

        if (input != Vector3.zero)
            transform.forward = input;
    }
}
