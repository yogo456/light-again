using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float playerMovementSpeed = 5.0f;

    private void Update()
    {
        MoveHorizontally();
    }

    private void MoveHorizontally()
    {
        float horizontalMovementValue = Input.GetAxis("Horizontal");
        Vector3 movementDirection = Vector3.right * horizontalMovementValue;
        gameObject.transform.position += movementDirection * playerMovementSpeed * Time.deltaTime;
    }
}