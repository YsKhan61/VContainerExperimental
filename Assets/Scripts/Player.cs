using UnityEngine;
using VContainer;


public class Player : MonoBehaviour
{
    private const string MESSAGE = "Player -> ";

    [Inject]
    private MonoBehaviour3 _monoBehaviour3;

    [Inject]
    private Class2 _class2;

    public void Run(string message)
    {
        Debug.Log(message + " Player.Run() called!");
    }

    public void LogMonoBehaviour3(string message)
    {
        _monoBehaviour3.Log(message + MESSAGE);
    }
}