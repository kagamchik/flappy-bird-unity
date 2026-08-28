using UnityEngine;

public class biordScrript : MonoBehaviour
{
        public LogicScript logic;

    public Rigidbody2D myRigidBody;
    public float  flapStrength;
    public bool birdIsAlive = true;
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
            
        }
        
        checkBorder();
        




    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        Time.timeScale = 0;
    }

    public void checkBorder()
    {
        if ((transform.position.y > logic.border || transform.position.y < -logic.border ) && birdIsAlive)
        {
            logic.gameOver();
            birdIsAlive = false;
            Time.timeScale = 0;
        }
       
    }
}
