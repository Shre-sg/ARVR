using UnityEngine;
using UnityEngine.UI;

public class Program2 : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject plane;
    public Material newMaterial;
    public Texture newTexture;

    public Button cubeButton;
    public Button sphereButton;
    public Button planeButton;

    void Start()
    {
        cubeButton.onClick.AddListener(ChangeCubeMaterial);
        sphereButton.onClick.AddListener(ChangeSphereTexture);
        planeButton.onClick.AddListener(ChangePlaneMaterial);
    }

    void ChangeCubeMaterial()
    {
        cube.GetComponent<Renderer>().material = newMaterial;
    }

    void ChangeSphereTexture()
    {
        sphere.GetComponent<Renderer>().material.mainTexture = newTexture;
    }

    void ChangePlaneMaterial()
    {
        plane.GetComponent<Renderer>().material = newMaterial;
        plane.GetComponent<Renderer>().material.mainTexture = newTexture;
    }
}
