using UnityEngine;

public class Rotating : MonoBehaviour
{
    // Expose a variable in the Inspector to control the rotation speed/axis
    public Vector3 rotationAmount = new Vector3(0, 50, 0); // Rotates 50 degrees/second on the Y-axis

    // Update is called once per frame
    void Update()
    {
        // Rotate the object every frame
        // Multiply by Time.deltaTime to make the rotation smooth and frame-rate independent
        transform.Rotate(rotationAmount * Time.deltaTime);
    }
}
