using UnityEngine;
using VContainer;

public class MonoBehaviour2 : MonoBehaviour
{
    private const string MESSAGE = "MonoBehaviour2 -> ";

    [Inject]
    private Class1 _class1;

    public void Run(string message)
    {
        Debug.Log(message + " MonoBehaviour2.Run() called!");
    }

    public void RunClass1(string message)
    {
        _class1.Run(message + MESSAGE);
    }
}
