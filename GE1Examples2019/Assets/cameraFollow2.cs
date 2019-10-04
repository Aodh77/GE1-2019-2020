using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow2 : MonoBehaviour
{
    public Transform cameraTarget;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, cameraTarget.position, Time.deltaTime);
        transform.LookAt(cameraTarget.parent);
    }
}
