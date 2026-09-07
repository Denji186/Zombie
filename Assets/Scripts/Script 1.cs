using UnityEngine;

public class Script1 : MonoBehaviour
{
    public GameObject Stick;
    float timer;
    public GameObject Canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Debug.Log("printing");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("timer is working");
        timer += Time.deltaTime;

        if (timer > 5)
        {
            Debug.Log("working");
            Stick.GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("gravity working");
        }
    }
    public void DestroyCanvas()
    {
        Destroy(Canvas);
    }
}
