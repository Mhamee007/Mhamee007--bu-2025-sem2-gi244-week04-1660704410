using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;
    public const string ENEMY_TAG = "enemy";

    private void Update()
    {
        Debug.Log("enemy pass:" + hitCount);

    }
    void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.tag == ENEMY_TAG)
        {
            hitCount++;
        }*/
       


        if (other.gameObject.CompareTag("enemy"))
        {
            hitCount++;
        }

        if (hitCount >= 5)
        {
          
            Debug.Log("GAME OVER");
            Time.timeScale = 0f;
        }

    }
}
