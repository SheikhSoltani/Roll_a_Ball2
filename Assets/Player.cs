using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Rigidbody rb;


    void Start()
    {
    }

    void Update()
    {
        rb.AddForce(1f, 0, 1f, ForceMode.Impulse);
    }
    public void Move(Rigidbody rb)
    {
        rb.AddForce(0, 0, 1f, ForceMode.Impulse);
    }
}
