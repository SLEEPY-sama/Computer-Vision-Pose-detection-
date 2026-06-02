using UnityEngine;
using UnityEngine.UI;

public class WebcamDisplay : MonoBehaviour
{

    public RawImage WebcamImage;
    // Reference to the RawImage component to display the webcam feed

    private WebCamTexture webcamTexture;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        webcamTexture = new WebCamTexture();
        WebcamImage.texture = webcamTexture;
        webcamTexture.Play();
        checkcamera();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void checkcamera()
    {
        foreach (WebCamDevice device in WebCamTexture.devices)
        {
            Debug.Log("Webcam found: " + device.name);
        }
    }
}
