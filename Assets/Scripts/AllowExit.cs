using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowExit : MonoBehaviour
{

    public GameObject treasure;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && treasure.gameObject.activeInHierarchy == false){
            this.gameObject.SetActive(false);
            Debug.Log("Hai vinto");
        }
    }
}
