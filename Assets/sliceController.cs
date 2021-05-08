using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliceController : MonoBehaviour
{
    public Object weapon;
    public Transform left;
    public Transform right;
    public Object half;
    public Object ball;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == (weapon.name))
        {
            Instantiate(half, left.position, left.rotation);
            Instantiate(half, right.position, right.rotation);
            Destroy(ball);
            Debug.Log("hit");
            
        }
    }
}
