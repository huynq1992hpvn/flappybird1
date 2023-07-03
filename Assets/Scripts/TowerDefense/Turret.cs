using UnityEngine;
public class Turret : MonoBehaviour
{
    public float radius;
    public LayerMask layerEnemy;
    private void Update()
    {
        CheckEnemies();
    }
    protected void CheckEnemies()
    {
        Collider2D enemy  = Physics2D.OverlapCircle(transform.position, radius, layerEnemy);
        if (enemy != null )
        {
            Debug.Log(enemy.transform.name);
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}