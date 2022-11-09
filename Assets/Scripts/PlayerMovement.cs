using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 position;
    public float speed = 1f;
    
    private Rigidbody _rb;
    
    // Start is called before the first frame update
    private void Start()
    {
        position = new Vector3(0, 0, 0);
       _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        throw new NotImplementedException();
    }

    private void FixedUpdate()
    {
        
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       if (horizontal != 0 || vertical != 0)
       {
           _rb.MovePosition(_rb.rotation * _rb.position +
                            new Vector3(horizontal, 0, vertical) * (Time.deltaTime * speed));
       }

       if (Input.GetButton("Jump"))
        {
            _rb.AddForce(20f * transform.up, ForceMode.Impulse);
        }
    }
}
