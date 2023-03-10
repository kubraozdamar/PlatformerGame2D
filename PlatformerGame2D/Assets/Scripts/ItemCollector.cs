using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fruit = 0;

    [SerializeField] Text fruitText;
    [SerializeField] AudioSource collectSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            fruit++;
            fruitText.text = "Pineapple: " + fruit;
        }
    }
}
