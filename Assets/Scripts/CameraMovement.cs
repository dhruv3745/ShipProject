using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject myObject;
    [SerializeField] private float followDistance;
        // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0, myObject.transform.position.z-followDistance);
        
    }

}