using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public float movementSpeed;
    private float horizontalMovement;
    private float verticalMovement;
    private Rigidbody rigidBody;
    [SerializeField] private float rotationMagnitude;
    [SerializeField] private Quaternion QuatTarget;
    [SerializeField] private Vector3 reverseQuaternion;
    [SerializeField] private float lerpTime;
    public Joystick joystick;
    public float sp;
    public float timeMultiplier = 1f;
    public Vector3 shipSpeed = new Vector3(0f,0f,0f);

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
        shipSpeed = new Vector3(horizontalMovement, verticalMovement,sp);
        shipSpeed*=timeMultiplier;
        rigidBody.velocity = shipSpeed;
        // Quaternion target = Quaternion.Euler(verticalMovement*rotationMagnitude,horizontalMovement*rotationMagnitude,);
        timeMultiplier+=0.01f;
    }
}
