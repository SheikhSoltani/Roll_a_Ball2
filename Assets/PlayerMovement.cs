using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player
{
    public void Move(Rigidbody rb)
    {
        rb.AddForce(0, 0, 1f, ForceMode.Impulse);
    }
}
