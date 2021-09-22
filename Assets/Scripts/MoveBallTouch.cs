using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallTouch : MonoBehaviour
{
    private Touch touch;
    public float speedWithSlide;
    public Rigidbody rb;


    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
    }

    public void MoveBallTouchs()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rb.AddForce(new Vector3(transform.position.x + touch.deltaPosition.x * speedWithSlide,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedWithSlide));
            }
        }
    }

    private void Update()
    {
        MoveBallTouchs();
    }
}
