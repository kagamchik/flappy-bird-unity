using UnityEngine;
using UnityEngine.Audio;

public class MiddleScript : MonoBehaviour

{
    public LogicScript logic;
    public AudioSource audioSource;
    public AudioClip CheckSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(CheckSound);
        logic.addScore(1);
    }
    
    
    
}
