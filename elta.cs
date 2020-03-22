using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elta : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Theplayer;
    public float targetDistance;
    public float allowedDistance = 5;
    public GameObject npc;
    public float follow;
    public RaycastHit skot;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Theplayer.transform);
        if (Physics.Raycast(transform.position, transform.InverseTransformDirection(Vector3.forward), out skot))
        {

            targetDistance = skot.distance;
            if (targetDistance >= allowedDistance)
            {
                follow = 1f;
                npc.GetComponent<Animation>().Play("HumanoidWalk");
                transform.position = Vector3.MoveTowards(transform.position, Theplayer.transform.position, follow);
            }
            else
            {
                follow = 0;
                npc.GetComponent<Animation>().Play("HumanoidIdle");
            }
        }   

    }
}
