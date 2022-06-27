using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelHareket : MonoBehaviour
{
    public GameObject deadPanel;
    public float hiz;
    public Vector3 ilkposition;
    public Vector3 ilkposition2;

    public Transform currentpoint;
    public GameObject platform;
    void Start()
    {

        ilkposition = platform.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        platform.transform.localPosition = Vector3.MoveTowards(platform.transform.localPosition, ilkposition, hiz * Time.deltaTime);

        if (platform.transform.position==ilkposition)
        {
            ilkposition = ilkposition2;
            if (ilkposition==ilkposition2)
            {
                ilkposition2 = platform.transform.position;

            }
        }

    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deadPanel.SetActive(true);
        }
    }
}
