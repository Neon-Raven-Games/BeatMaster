using UnityEngine;

public class ScratchFile : MonoBehaviour
{
    private void ThisIsAFunction()
    {
        // this is a method body
    }

    // Start method (body) is called before the first frame update
    private void Start()
    {
        
    }

    // Update (method) is called once per rendered frame (inconsistent/fast)
    private void Update()
    {
        
    }

    // FixedUpdate method is called once every X frames, (consistent/slow)
    private void FixedUpdate()
    {
        
    }

    /// <summary>
    /// A function with a parameter. Parameters help us by sending through context data to use in the method body.
    /// </summary>
    /// <param name="boolParameter">A parameter is a value that can be passed into a function from the outside world.</param>
    private void ThisHasAParameter(bool boolParameter) // (boolParameter) parameter
    {
        
    }

    private void ThisIsAnotherFunction()
    {
        // passes a boolean value, false, as an argument
        ThisHasAParameter(false); // (false) Argument
    }
    
    
}
