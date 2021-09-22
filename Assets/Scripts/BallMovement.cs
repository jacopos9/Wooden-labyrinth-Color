using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [Range(1,20)]
    public float velocityBall;
    float inputX;
    float inputY;

    InputsSystem inputSystem;
    Rigidbody rb;

    private Touch touch;
    public float speedWithSlide;


    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
    }

    void MoveBallJoystick()
    {
        inputSystem = GameObject.Find("Joystick_BackGround").GetComponent<InputsSystem>();
        inputX = inputSystem.InputHorizontal();
        inputY = inputSystem.InputVertical();
        rb.AddForce( new Vector3(inputX, 0, inputY) * velocityBall);
    }
    
    public void MoveBallTouch()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {/*
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedWithSlide,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedWithSlide);
                */

                rb.AddForce(new Vector3(transform.position.x + touch.deltaPosition.x * speedWithSlide,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedWithSlide));
            }
        }
    }
  

    private void Update()
    {
        MoveBallJoystick();
        //MoveBallTouch();
    }

}
