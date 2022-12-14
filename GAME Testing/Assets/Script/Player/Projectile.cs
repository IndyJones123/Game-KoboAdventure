using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float fireballspeed;
    private float direction;
    private bool hit;
    private float lifetime;

    private Animator anim;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (hit) return;
        float movementSpeed = fireballspeed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > 5) gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            hit = true;
            boxCollider.enabled = false;
            anim.SetTrigger("explode");
        }

        if (collision.tag == "Enemy")
        {
            hit = true;
            boxCollider.enabled = false;
            anim.SetTrigger("explode");
        }
        if (collision.tag == "Boss")
        {
            collision.GetComponent<HealthBos>().TakeDamage(1);
            hit = true;
            boxCollider.enabled = false;
            anim.SetTrigger("explode");
        }
            

    }
    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}