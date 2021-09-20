using UnityEngine;
using UnityEngine.Events;

public class TriggerBall : MonoBehaviour
{
    public UnityEvent onBallDetected;


    private void OnTriggerEnter(Collider other)
    {
        onBallDetected?.Invoke();
    }

}
