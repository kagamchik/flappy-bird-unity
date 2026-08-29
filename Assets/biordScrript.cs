using UnityEngine;

public class biordScrript : MonoBehaviour
{
        public LogicScript logic;

    public Rigidbody2D myRigidBody;
    public float  flapStrength;
    public bool birdIsAlive = true;
    public AudioSource audioSource;
    public AudioClip flapSound;
    public AudioClip deathSound;
    public AudioClip CheckSound;
    // public float  border = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
            audioSource.PlayOneShot(flapSound);
        }
        
        checkBorder();
        




    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(deathSound);
        logic.gameOver();
        birdIsAlive = false;
        Time.timeScale = 0;
    }

    public void checkBorder()
    {
        if ((transform.position.y > logic.border || transform.position.y < -logic.border ) && birdIsAlive)
        {
            audioSource.PlayOneShot(deathSound);
            logic.gameOver();
            birdIsAlive = false;
            Time.timeScale = 0;
        }
       
    }
}
