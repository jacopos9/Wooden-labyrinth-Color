using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeController : MonoBehaviour
{
     public bool touchMovement;
     public bool joystickMovement;

    public MoveBallTouch moveBallTouch;
    public BallMovement ballMovement;

    private void Start()
    {
        joystickMovement = true;
        touchMovement = false;

        moveBallTouch = FindObjectOfType<MoveBallTouch>();
        ballMovement = FindObjectOfType<BallMovement>();
    }

    public void ChangeUsingController()
    {
        if (touchMovement)
        {
            moveBallTouch.GetComponent<MoveBallTouch>().enabled = true;
        }
        else moveBallTouch.GetComponent<MoveBallTouch>().enabled = false;

        if (joystickMovement)
        {
            ballMovement.GetComponent<BallMovement>().enabled = true;
        }
        else ballMovement.GetComponent<BallMovement>().enabled = false;

    }

    public void ButtonChange()
    {
        
        // se è attivo il joystick, quanto si schiaccia bisogna disattivare ball joystick e attivare il ball movemnt

        if (joystickMovement)
        {
            joystickMovement = !joystickMovement;
            touchMovement = true;
        }
        else if (touchMovement)
        {
            touchMovement = !touchMovement;
            joystickMovement = true;

        }
    }

    private void Update()
    {
        ChangeUsingController();
    }
}
