using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    float movespeed  = 5f;
    float rotatespeed = 1.0f;
    float jumpforce = 5f;

    int maxspeed = 5;
    private Rigidbody Playerrb;

    public ParticleSystem jumpParticle;
    public ParticleSystem starParticle;

    public ParticleSystem goal;
    // Start is called before the first frame update
    void Start()
    {
        Playerrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }

    private void Movement()
    {
        //doesn't work for smoke
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movespeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movespeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotatespeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotatespeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Playerrb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }*/

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(0, h * rotatespeed, 0));

        Playerrb.AddForce(v * transform.forward * movespeed);

        Playerrb.velocity = new Vector3(Mathf.Clamp(Playerrb.velocity.x, -maxspeed, maxspeed),
            Mathf.Clamp(Playerrb.velocity.y, -maxspeed, maxspeed),
            Mathf.Clamp(Playerrb.velocity.z, -maxspeed, maxspeed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Playerrb.AddForce(new Vector3(0, jumpforce, 0), ForceMode.Impulse);
            jumpParticle.Play();
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            starParticle.Play();
        }
    }

}
