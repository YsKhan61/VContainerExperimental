using UnityEngine;
using VContainer;
using VContainer.Unity;

public class MonoBehaviour3 : MonoBehaviour
{
    private const string MESSAGE = "MonoBehaviour3 -> ";

    [SerializeField]
    private Player _playerPrefab;

    private IObjectResolver _objectResolver;
    private Class1 _class1;
    private Player _spawnedPlayer;

    [Inject]
    public void InjectDependencies(IObjectResolver objectResolver, Class1 class1)
    {
        _objectResolver = objectResolver;
        _class1 = class1;
    }

    public void Run(string message)
    {
        Debug.Log(message + " MonoBehaviour3.Run() called!");
        SpawnPlayer(message);
        RunPlayer(message);
    }

    public void Log(string message)
    {
        Debug.Log(message + " MonoBehaviour3.Log() called!");
    }

    public void RunClass1(string message)
    {
        _class1.Run(message + MESSAGE);
    }

    private void SpawnPlayer(string message)
    {
        Debug.Log(message + " Spawning Player!");
        _spawnedPlayer = _objectResolver.Instantiate(_playerPrefab);
    }

    private void RunPlayer(string message)
    {
        _spawnedPlayer.Run(message + MESSAGE);
        _spawnedPlayer.LogMonoBehaviour3(message + MESSAGE);
    }
}
