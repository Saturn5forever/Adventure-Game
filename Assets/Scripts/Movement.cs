using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    public InputAction moveKeys;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveKeys.Enable();
    }

    void FixedUpdate()
    {
        Vector2 moveDirection = moveKeys.ReadValue<Vector2>().normalized;

        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed) * Time.deltaTime;
    }
}
