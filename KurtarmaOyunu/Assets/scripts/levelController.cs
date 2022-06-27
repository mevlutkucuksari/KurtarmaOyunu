using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelController : MonoBehaviour
{
    public GameObject winPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            winPanel.SetActive(true);
        }
    }
}
