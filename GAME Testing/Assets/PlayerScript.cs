using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    
    public Animator anim;
    public float JumpForce;
    float score;

    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
                anim.SetTrigger("jump");
            }
        }    
        if(isAlive)
        {
            score += Time.deltaTime * 2500;
            ScoreTxt.text = "SCORE : " + score.ToString("F");

        }
        if(score==696969)
        {
            SceneManager.LoadScene("Dunia3");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }
        if(collision.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }
    }
}
