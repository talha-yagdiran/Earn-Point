using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    float speed;
    private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;
        }

        else
            speed = 1;

        if (Input.GetKey(KeyCode.W))
        {
            _rb.linearVelocity =  Vector3.forward * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rb.linearVelocity = Vector3.back * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.linearVelocity = Vector3.left * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.linearVelocity = Vector3.right * speed;
        }
    }

}
