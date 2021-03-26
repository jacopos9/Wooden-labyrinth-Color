using UnityEngine;

public class BallProperty : MonoBehaviour
{
   public GameObject ball;

    
    public void ChangeColor()
    {
        GetComponentInChildren<Renderer>().material.color = Random.ColorHSV();
    }

    public void ResetColorToOriginal()
    {
        GetComponentInChildren<Renderer>().material.color = Color.white;
    }
    
}
