using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] public Vector3 movementspeed;
    [SerializeField] private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
      
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + movementspeed * Time.fixedDeltaTime);
    }
   
}
