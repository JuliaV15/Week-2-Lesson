using UnityEngine;

public class StaticMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 vee = new Vector2(6, 18);

        float magnitude = MethodExamples.GetMagnitude(vee); // getMagnitude was from a whole other script but we called it here (we made the GetMagnitude public in the other script)

        print($"This is inside Static Methods: {magnitude}"); // the "$" makes it so that we use a variable in a string. if we didn't have the $ then it would straight up print the {magnitude} rather than the variable
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
