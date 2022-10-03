using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Reference to the Player
    // It is necessary to add the Player object through the Unity Platform
    public Transform player;

    // Variable to modify the position of the camera compared to the Player
    // Vector3 stores 3 float numbers
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
