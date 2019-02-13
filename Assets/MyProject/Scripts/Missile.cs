using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Missile : MonoBehaviour
{

    public Transform target;
    public float speed = 5f;
    public float rotateSpeed = 200f;

    public GameObject explotionEffect;


    private Rigidbody2D rb2d;

    private GameObject mExpEffects;

    private GameObject mTarget;



    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        mTarget = GameObject.FindGameObjectWithTag("Player");
        target = mTarget.transform;

        Vector2 direction = (Vector2)target.position - rb2d.position;
        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb2d.angularVelocity = -rotateAmount * rotateSpeed;

        rb2d.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D()
    {
        mExpEffects = Instantiate(explotionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
