using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    GameObject player;
    bool isDestroy = false;
    Animator animator;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Dead"))
        {
            Destroy(gameObject);
        }
        else if(!Data.isGameOver)
        {
            transform.LookAt(player.transform);
            transform.Translate(Vector3.forward * Time.deltaTime * 5f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            Data.isGameOver = true;
            Destroy(gameObject);
        }

        if(collision.gameObject.tag.Equals("Peluru"))
        {
            isDestroy = true;
            Data.Score++;
            animator.SetBool("isDead", true);
        }
    }
}