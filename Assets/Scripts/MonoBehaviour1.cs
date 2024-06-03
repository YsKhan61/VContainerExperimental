using UnityEngine;
using VContainer;


public class MonoBehaviour1 : MonoBehaviour
{
    private const string MESSAGE = "MonoBehaviour1 -> ";

    [Inject]                    // Property/Field Injection
    private MonoBehaviour2 _monoBehaviour2;

    public void Run(string message)
    {
        Debug.Log(message + " MonoBehaviour1.Run() called!");
    }

    public void RunMonoBehaviour2(string message)
    {
        _monoBehaviour2.Run(message + MESSAGE);
    }
}
