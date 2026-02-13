using UnityEngine;

public class HealthV1 : MonoBehaviour
{
    public int maxHp = 100;
    public void TakeDamage(int damage)
    {
        maxHp -= damage;
        if (maxHp <= 0)
        { 
            Destroy(gameObject);
        }
    }
}
