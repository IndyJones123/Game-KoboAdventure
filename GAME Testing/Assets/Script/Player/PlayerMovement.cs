using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private AudioClip loncat;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    private float wallJumpCooldown;
    private float horizontalInput;
    
    //Awake Method berfungsi untuk mengeksekusi script setiap game melakukan load
    private void Awake(){
        //getComponent berfungsi untuk mengakses function yang berada pada unity 
        //Rigidbody2D digunakan untuk memberikan physics pada Object
        //Animator digunakan untuk memberikan animasi pada object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    //Update Method digunakan untuk melakukan pergerakan arah pada body player mengunakan vector 
    private void Update(){
        if(DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        float horizontalInput = Input.GetAxis("Horizontal");

        //Vector2 Digunakan untuk memberikan vector pada karakter 2D apabila menggunakan Vector3 nantinya digunakan untuk karakter 3D dengan vektor x
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        //Melakukan Flip karakter jika bergerak ke kanan atau ke kiri dengan localScale
        if(horizontalInput > 0.25f)
            {
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);
            }
        if (horizontalInput < -0.25f){
            transform.localScale = new Vector3(-0.5f,0.5f,0.5f);
            }
        
        
        //Input.GetKey(Keycode.Space) digunakan untuk mengcheck player dalam menekan tombol Space
        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
        
        Jump();
        
        
            

        }
        //inisialisasi animator parameter menjadi 0 yang nantinya dipangil if apakah 0 != 0 yang memberikan bolean false
        anim.SetBool("run", horizontalInput!=0);
        anim.SetBool("grounded", isGrounded());
    
        
    }

    private void Jump(){
        //Vector2 Digunakan untuk memberikan vector pada karakter 2D apabila menggunakan Vector3 nantinya digunakan untuk karakter 3D dengan vektor y
        SoundManagerScript.instance.PlaySound(loncat);
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("jump");
    }

    private void OnCollisionEnter2D(Collision2D collision){

    }

    private bool isGrounded(){
        //RayCast disini ialah untuk membuat sebuah kotak penentu keadaan seperti sensor apabila object menyentuh sensor / overlapping maka akan dapat menentukan keadaan menjadi true atau false
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size,0,Vector2.down,0.1f,groundLayer);
        return raycastHit.collider != null;
    }

    private bool onWall(){
        //RayCast disini ialah untuk membuat sebuah kotak penentu keadaan seperti sensor apabila object menyentuh sensor / overlapping maka akan dapat menentukan keadaan menjadi true atau false
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size,0,new Vector2(transform.localScale.x,0),0.1f,wallLayer);
        return raycastHit.collider != null;
    }
        public bool canAttack()
    {
        return horizontalInput == 0 && !onWall();
    }
}
