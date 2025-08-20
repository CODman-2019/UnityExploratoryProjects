using Unity.VisualScripting;
using UnityEngine;

public class Throw: MonoBehaviour
{
    public GameObject throwable;
    public Vector3 forceApplied;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject item;
            item = GameObject.Instantiate(throwable);
            item.GetComponent<Rigidbody>().AddForce(forceApplied);
            Destroy(item, 1f);
        }
    }
}
