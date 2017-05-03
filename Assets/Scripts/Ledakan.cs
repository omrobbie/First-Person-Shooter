using UnityEngine;

public class Ledakan : MonoBehaviour
{
    public GameObject particleLedakan;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint cp = collision.contacts[0];
        Quaternion rotasi = Quaternion.FromToRotation(Vector3.up, cp.normal);
        GameObject.Instantiate(particleLedakan, cp.point, rotasi);
        Destroy(gameObject);
    }
}