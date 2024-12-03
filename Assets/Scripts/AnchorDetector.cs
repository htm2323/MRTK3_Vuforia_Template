using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorDetector : MonoBehaviour
{
    [SerializeField] GameObject anchor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintAnchorPos()
    {
        Debug.Log(anchor.GetComponent<Transform>().transform.position);
    }
}
