using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    //4. method: public
    public GameObject flyInstance;
    public float speed = 4.0f;  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //3. method:
        //flyInstance = GameObject.Find("fly");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //1.
        //rb.velocity = 10*Vector3.up;
        
        //2.
        //flyInstance.transform.Translate(Vector3.right);
        
        //3.
        GameObject clone = Instantiate(flyInstance);
        clone.transform.position = new Vector3(Random.Range(-6, 6), 0);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.name == "fly") { Destroy(flyInstance); }

    }
}
