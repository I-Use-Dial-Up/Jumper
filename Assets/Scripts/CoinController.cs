using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameObject deathEffect;
    private AudioSource audioSource;
    public AudioClip coinPickupSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        CollectCoin();
        
    }

    private void CollectCoin()
    {
        audioSource = GameObject.Find("Player").GetComponent<AudioSource>();
        audioSource.PlayOneShot(coinPickupSound, 1.0f);
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
