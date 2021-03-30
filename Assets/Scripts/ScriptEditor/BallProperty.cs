using UnityEngine;

public class BallProperty : MonoBehaviour
{
   public GameObject ball;

    public Material[] material;
    public bool AssegnedColor;

    [Range(0,1000)]
    public int example;

    public string expale;


    public void ChangeColor()
    {
        GetComponentInChildren<Renderer>().material.color = Random.ColorHSV();
    }

    public void ResetColorToOriginal()
    {
        GetComponentInChildren<Renderer>().material.color = Color.white;
    }

    public void AssignMaterial()
    {
        GetComponentInChildren<Renderer>().material.color = material[1].color;
        //AssegnedColor = true;

        foreach (var item in material)
        {
         
        }

    }
    
}
