using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;      // Forward/back movement speed
    public float turnSpeed = 100f;  // Rotation speed in degrees per second

    public InputAction MoveAction;  // Input mapping for movement

    private Vector2 moveInput;      // Current frame's input (x = turn, y = move)

    void Start()
    {
        MoveAction.Enable();        // Activate input so it reports values
    }

    void Update()
    {
        moveInput = MoveAction.ReadValue<Vector2>();  // Read this frame's input

        // Move forward/back, scaled by speed and input (frame-rate independent)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Turn left/right around the vertical axis
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
