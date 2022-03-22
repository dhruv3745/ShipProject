using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    float horizontalMovement;
    float verticalMovement;
    private Rigidbody rigidBody;
    public float rotationMagnitude;
    public Quaternion QuatTarget;
    public Vector3 reverseQuaternion;
    public float lerpTime;
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        QuatTarget = Quaternion.Euler(reverseQuaternion);
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = joystick.Horizontal*movementSpeed;
        verticalMovement = joystick.Vertical*movementSpeed;
        reverseQuaternion = new Vector3(verticalMovement*rotationMagnitude, 0, horizontalMovement * rotationMagnitude);
        QuatTarget = Quaternion.Euler(reverseQuaternion);
        transform.rotation=Quaternion.Lerp(transform.rotation,QuatTarget,Time.deltaTime * lerpTime);
    }

    private void FixedUpdate() {
        rigidBody.velocity = new Vector3(horizontalMovement, verticalMovement, 0);
        // Quaternion target = Quaternion.Euler(verticalMovement*rotationMagnitude,horizontalMovement*rotationMagnitude,0);
    }
}
