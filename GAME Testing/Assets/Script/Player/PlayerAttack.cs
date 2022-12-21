using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject[] Fireballs;
    [SerializeField] private AudioClip Ehe;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        SoundManagerScript.instance.PlaySound(Ehe);
        cooldownTimer = 0;

        Fireballs[FindFireball()].transform.position = FirePoint.position;
        Fireballs[FindFireball()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
    private int FindFireball()
    {
        for (int i = 0; i < Fireballs.Length; i++)
        {
            if (!Fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}