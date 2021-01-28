using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject PlayerView;
    public GameObject TopView;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraControl();
    }
    void CameraControl()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            PlayerView.gameObject.SetActive(false);
            TopView.gameObject.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            PlayerView.gameObject.SetActive(true);
            TopView.gameObject.SetActive(false);
        }
    }
}
