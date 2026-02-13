using UnityEngine;

public class HealthV2 : MonoBehaviour
{
    public int MaxHp = 100;
    private int takeDamage = 0;
    public void TakeDamage(int damage)
    {
        takeDamage +=  damage;
    }
}
