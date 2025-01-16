using UnityEngine;

public class RaycastShooting : MonoBehaviour
{
    public Transform firePoint; // Point where the raycast starts
    public LineRenderer lineRenderer; // LineRenderer component to visualize the ray
    public float rayLength = 10f;

    void Update()
    {
        ShootRaycast();
    }

    void ShootRaycast()
    {
        Vector2 firePointPosition = firePoint.position;
        Vector2 direction = firePoint.up; // Use the local "up" direction of the firePoint

        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, direction, rayLength);

        if (hit)
        {
            DrawLine(firePointPosition, hit.point);
        }
        else
        {
            DrawLine(firePointPosition, firePointPosition + direction * rayLength);
        }
    }

    void DrawLine(Vector2 start, Vector2 end)
    {
        lineRenderer.SetPosition(0, start);
        lineRenderer.SetPosition(1, end);
    }
}
