using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePath : MonoBehaviour
{
    private List<Vector2> PathNodes = new List<Vector2>();
    public GameObject BloodPathVisual;
    public float distance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void CreateNode()
    {
        Vector3 p = Input.mousePosition;
        p.z = 20;
        Vector3 pos = Camera.main.ScreenToWorldPoint(p);
       //bloodPathVisual.transform.position = pos;
        PathNodes.Add(pos);
        Instantiate(BloodPathVisual, pos, Quaternion.identity);      
    
    

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateNode();
        }
    
    }
}
