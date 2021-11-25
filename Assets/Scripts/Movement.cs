using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    private Rigidbody rb;
    
    public static Action StartDaGame;
    public static Action PushX;
    public static Action PushSpace;
    public static Action Hug;

    public GameObject Player;

    public int Time = 10;

    void Start()
    {
        Invoke("StartDa", 0.1f);
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * Speed);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PushX?.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PushSpace?.Invoke();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mort"))
        {
            Instantiate(Player, new Vector3(0 , 0, 0), Quaternion.identity );
            Destroy(gameObject);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MrCube"))
        {
            Time -= 100;
        }
        
        if (other.gameObject.CompareTag("MrCube") && Time <= 0)
        {
            Hug?.Invoke();
        }
    }

    public void StartDa()
    {
        StartDaGame?.Invoke();
    }
}