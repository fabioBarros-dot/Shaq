using UnityEngine;
using Unity.Cinemachine;

public class LockCamera : MonoBehaviour
{
    public CinemachineCamera cameraFixa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cameraFixa.Priority = 10;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cameraFixa.Priority = 0;
        }
    }
}
