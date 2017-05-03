using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PointPistol : MonoBehaviour
{
    public Rigidbody bullet;
    [Range(0, 100)]
    public float speed = 30;

    private void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Rigidbody newBullet = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            newBullet.velocity = transform.TransformDirection(Vector3.forward * speed);
            Physics.IgnoreCollision(newBullet.GetComponent<SphereCollider>(), transform.parent.GetComponent<BoxCollider>(), true);
        }
    }
}