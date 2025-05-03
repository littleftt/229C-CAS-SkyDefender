using UnityEngine;

public class Projectile2D : MonoBehaviour
{

    public CoolDown coolDown;

    public Transform FirePoint;

    public GameObject crossHair;

    public Rigidbody2D projectilePrefab;

    private int projectileCount;

    void Update()
    {

        if (coolDown.IsCoolingDown) return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * 5f, Color.magenta, 5f);

            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                crossHair.transform.position = new Vector2(hit.point.x, hit.point.y);

                Vector2 projectileVelocity = CalculateProjectileVelocity(FirePoint.position, hit.point, 1f);

           
                Rigidbody2D firedBullet = Instantiate(projectilePrefab, FirePoint.position, Quaternion.identity);

                firedBullet.linearVelocity = projectileVelocity;
                projectileCount++;

                if (projectileCount == 5)
                {
                    coolDown.StartCoolDown();
                    projectileCount = 0;
                }
            }
        }
    }

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;

        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        return new Vector2(velocityX, velocityY);
    }
}
