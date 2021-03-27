using UnityEngine;

public class InputsSystem : MonoBehaviour
{
    public Vector3 direction;
    float maxRotation = 30f;
    
    // input pc

    void PcInputs()
    {
        float h = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, z) * 3f * Time.deltaTime);
    }

    void MoveBoard()
    {
        float h = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.localRotation = Quaternion.Euler(new Vector3(h * 30f, 0 * 30f, z * 30f));
    }





    // input Accelerometro
    public void Accelerometer()
    {
        float x = Input.acceleration.x;
        float y = Input.acceleration.y;
        float z = Input.acceleration.z;

        gameObject.transform.rotation = Quaternion.Euler(new Vector3(x * maxRotation, y * maxRotation, z * maxRotation));
    }

    private void Update()
    {
        Accelerometer();
        PcInputs();
        //MoveBoard();
    }


}
