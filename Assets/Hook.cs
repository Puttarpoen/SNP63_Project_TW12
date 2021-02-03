using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public int links;
    public GameObject linkPrefab;
    public GameObject connectedObject;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D prevLinkRB = GetComponent<Rigidbody2D>();
        for (int i=0; i<links; i++)
        {
            GameObject link = Instantiate(linkPrefab, transform);


            link.GetComponent<HingeJoint2D>().connectedBody = (i==0) ? GetComponent<Rigidbody2D>() : prevLinkRB;
            prevLinkRB = link.GetComponent<Rigidbody2D>();

            if (i == links - 1)
            {
                SetConnectedObject(connectedObject, prevLinkRB);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetConnectedObject(GameObject obj, Rigidbody2D rb)
    {
        HingeJoint2D hingeJoint = obj.AddComponent<HingeJoint2D>();
        hingeJoint.connectedBody = rb;
        hingeJoint.autoConfigureConnectedAnchor = false;
        hingeJoint.anchor = new Vector2(0, .12f);
        hingeJoint.connectedAnchor = Vector2.zero;
    }
    public void hit()
    {
        Destroy(connectedObject.GetComponent<HingeJoint2D>());
    }

}
