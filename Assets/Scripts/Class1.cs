using UnityEngine;
using VContainer;

public class Class1
{
    private const string MESSAGE = "Class1 -> ";

    /*[Inject]            // Consttructor Injection
    public Class1(MonoBehaviour1 monoBehaviour1)
    {
        _monoBehaviour1 = monoBehaviour1;
    }*/

    private MonoBehaviour1 _monoBehaviour1;

    public void InjectDependencies(MonoBehaviour1 monoBehaviour1)
    {
        _monoBehaviour1 = monoBehaviour1;
    }

    public void Run(string message)
    {
        Debug.Log(message +  " Class1.Run() called!");
    }

    public void RunMonoBehaviour1(string message)
    {
        _monoBehaviour1.Run(message + MESSAGE);
    }
}
