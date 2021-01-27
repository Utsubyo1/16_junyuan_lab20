using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Playergo;
    Vector3 posOffset = new Vector3(0, 8.0f, -9.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Playergo.transform.position + posOffset, 0.1f);

        if (Input.GetKeyDown(KeyCode.Tab))
        {

        }
    }
}
