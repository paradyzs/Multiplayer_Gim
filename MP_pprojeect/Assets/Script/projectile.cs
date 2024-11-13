using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        PlayerShoot target = collision.gameObject.GetComponent<PlayerShoot>();
        if (target != null)
        {
            target.Hit(damage);
        }

        Destroy(gameObject); // Destroy the projectile on impact
    }
}
