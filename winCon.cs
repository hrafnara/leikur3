using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCon : MonoBehaviour
{
    public elta elting;
    public GameObject veggurinn;
    public GameObject destroyedVersion;
    // Update is called once per frame
    void OnMouseDown()
    {
         
            Debug.Log("gerðist");
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(veggurinn);
            elting.enabled = true;
   
        
    }
}
