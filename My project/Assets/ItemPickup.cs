using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class ItemPickup : MonoBehaviour
{
    public AudioClip ding;
    AudioSource audioSource;
    float isCollected;
    public Transform player;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isCollected = 0;
    }

    void Update()
    {
        this.transform.Rotate(0, 0, 1);
    }

    void OnTriggerExit()
    {
        if (isCollected == 1)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter()
    {
        audioSource.PlayOneShot(ding, 0.7F);
        isCollected = 1;
        player.GetComponent<Burgers>().points++;
        return;
    }
}
