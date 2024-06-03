using UnityEngine;
using VContainer.Unity;


public class Class2 : IInitializable, IStartable, IPostStartable
{
    public void Initialize()
    {
        Debug.Log("Class2.Initialize() called!");


    }

    public void Start()
    {
        Debug.Log("Class2.Start() called!");
    }

    public void PostStart()
    {
        Debug.Log("Class2.PostStart() called!");
    }
}
