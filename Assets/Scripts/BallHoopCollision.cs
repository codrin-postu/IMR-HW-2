using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHoopCollision : MonoBehaviour
{

    public GameObject hoopTrigger;
    public GameObject successParticles;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

     void OnTriggerEnter(Collider col)
    {
        if (col.name == hoopTrigger.name)
        {
            Debug.Log("Collided");
            PlayParticle();
        }
    }

    private void PlayParticle()
    {
        GameObject particle = Instantiate(successParticles, transform.position, Quaternion.identity);
        particle.GetComponent<ParticleSystem>().Play();
    }
}
