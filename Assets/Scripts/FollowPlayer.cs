using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;                          // Target the camera follows
    private Vector3 offset = new Vector3(0, 5, -7);    // Camera position relative to player

    void Start()
    {

    }

    // Runs after movement so the camera tracks the player's final position
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  // Stay locked at offset behind player
    }
}
