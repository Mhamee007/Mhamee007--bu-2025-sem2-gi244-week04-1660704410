using UnityEngine;

public class Food : MonoBehaviour
{
    public int attackPoint = 5;

    void OnTriggerEnter(Collider other)
    {
        /*var health =  other.gameObject.GetComponent<HealthV1>();
          if (health != null)
          {
              health.TakeDamage(attackPoint);

          }
          Destroy(gameObject);*/
        if (other.gameObject.TryGetComponent<HealthV1>(out HealthV1 health))
        {
            health.TakeDamage(attackPoint);
        }
        Destroy(gameObject);
            
        
    }
}
