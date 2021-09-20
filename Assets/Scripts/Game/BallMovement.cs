using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [Range(1,20)]
    public float velocityBall;
    float inputX;
    float inputY;

    InputsSystem inputSystem;
    Rigidbody rb;

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

    private void Update()
    {
        MoveBallJoystick();
    }

}
