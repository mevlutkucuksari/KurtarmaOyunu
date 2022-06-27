using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class su : MonoBehaviour
{
    public GameObject deadPanel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deadPanel.SetActive(true);
        }
    }
}
