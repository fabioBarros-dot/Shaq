using UnityEngine;

public class Movimentation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
