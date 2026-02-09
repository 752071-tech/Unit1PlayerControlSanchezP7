using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private varibles
    private float speed = 20.0f;
    private float turnspeed = 35.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        
        // Well move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}
