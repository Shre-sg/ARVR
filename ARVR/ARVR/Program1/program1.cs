using UnityEngine;

public class AdvancedTransform : MonoBehaviour
{
    public GameObject myCube;
    public GameObject mySphere;
    public GameObject myPlane;

    public float cubeMoveSpeed = 2f;
    public float sphereMoveSpeed = 1.5f;
    public float planeMoveSpeed = 3f;

    public float rotationSpeed = 50f;
    public float scaleSpeed = 0.5f;

    void Update()
    {
        // Cube transformations
        if (Input.GetKey(KeyCode.C)) // Move Cube
        {
            myCube.transform.position += new Vector3(cubeMoveSpeed * Time.deltaTime, 0, 0);  // Move in X direction
        }

        if (Input.GetKey(KeyCode.X)) // Scale Cube
        {
            myCube.transform.localScale += new Vector3(scaleSpeed * Time.deltaTime, 0, 0);  // Scale on X axis
        }

        if (Input.GetKey(KeyCode.Z)) // Rotate Cube
        {
            myCube.transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);  // Rotate along X axis
        }

        // Sphere transformations
        if (Input.GetKey(KeyCode.S)) // Move Sphere
        {
            mySphere.transform.position += new Vector3(0, sphereMoveSpeed * Time.deltaTime, 0);  // Move in Y direction
        }

        if (Input.GetKey(KeyCode.W)) // Scale Sphere
        {
            mySphere.transform.localScale += new Vector3(0, scaleSpeed * Time.deltaTime, 0);  // Scale on Y axis
        }

        if (Input.GetKey(KeyCode.A)) // Rotate Sphere
        {
            mySphere.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);  // Rotate along Y axis
        }

        // Plane transformations
        if (Input.GetKey(KeyCode.P)) // Move Plane
        {
            myPlane.transform.position += new Vector3(0, 0, planeMoveSpeed * Time.deltaTime);  // Move in Z direction
        }

        if (Input.GetKey(KeyCode.Q)) // Scale Plane
        {
            myPlane.transform.localScale += new Vector3(0, 0, scaleSpeed * Time.deltaTime);  // Scale on Z axis
        }

        if (Input.GetKey(KeyCode.E)) // Rotate Plane
        {
            myPlane.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);  // Rotate along Z axis
        }
    }
}
