using UnityEngine;
using System.Collections;

public class SpearCollider : MonoBehaviour
{
    public int beenHit = 0;

    void Update()
    {
        if (beenHit >= 3)
        {
            Debug.Log("You've been hit 3 times, you're ded.");
            //GameManager.instance.GameOver();
            //Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You got stabbed!");
            beenHit = beenHit + 1;
        }
    }
}
