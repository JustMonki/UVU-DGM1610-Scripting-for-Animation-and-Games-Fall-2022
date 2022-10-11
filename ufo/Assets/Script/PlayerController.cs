using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float hInput;
    public float Speed;
    public float xRange;
    public GameObject Laser;
    public Transform blaster;
    private AudioSource blasterAudio;
    public AudioClip lasterBlast;


    // Start is called before the first frame update
    void Start()
    {
        blasterAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       hInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * hInput * Speed * Time.deltaTime);

        //boundaries
       if(transform.position.x > xRange)
       {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
       }

       if(transform.position.x < -xRange)
       {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       }

        if(Input.GetKeyDown(KeyCode.Space))
        {   
            blasterAudio.PlayOneShot(lasterBlast,1.0f);
            Instantiate(Laser, blaster.transform.position, Laser.transform.rotation);
        }
    }
}
