using UnityEngine;

public class Movimentation : MonoBehaviour
{
    public float velocidade = 4f;

    private Rigidbody2D rb;
    private Vector2 direcaoInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        LoadInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void LoadInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (x != 0)
        {
            y = 0;
        }

        direcaoInput = new Vector2(x, y).normalized;
    }

    void Move()
    {
        rb.linearVelocity = direcaoInput * velocidade;
    }
}
