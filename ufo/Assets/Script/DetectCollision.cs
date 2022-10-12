using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public ScoreManager ScoreManager; // variable to reference score manager
    public int scoreToGive;
    public ParticleSystem explosionParticle; //store particles


    // Start is called before the first frame update
    void Start()
    {
        ScoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

 
    void OnTriggerEnter(Collider other)
    {
        Explision();
        explosionParticle.transform.parent = null;
        ScoreManager.IncreaseScore(scoreToGive); //increase score by scoretogive value
        Destroy(gameObject); // destroy other game object it hits
        Destroy(other.gameObject); //destory this game oboject
    }

    public void Explision()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }
}
