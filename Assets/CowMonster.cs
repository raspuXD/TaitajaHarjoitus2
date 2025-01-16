using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMonster : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cow"))
        {
            CowMilkProducer hoho = collision.GetComponent<CowMilkProducer>();
            if (hoho != null)
            {
                hoho.howManyTimesHit++;
                hoho.DIE();
                Destroy(gameObject);
            }

            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory inve = collision.GetComponent<Inventory>();
            if (inve != null)
            {
                inve.Insanity += 7.5f * Time.deltaTime; // Apply insanity over time
            }
        }
    }
}
