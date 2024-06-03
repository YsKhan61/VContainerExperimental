using UnityEngine;
using VContainer;
using VContainer.Unity;


public class ApplicationController : LifetimeScope
{
    private const string MESSAGE = "Application Controller -> ";


    [SerializeField]
    private MonoBehaviour1 _monoBehaviour1;

    [SerializeField]
    private MonoBehaviour2 _monoBehaviour2;

    [SerializeField]
    private MonoBehaviour3 _monoBehaviour3;

    private Class1 _class1;

    protected override void Configure(IContainerBuilder builder)
    {
        // Registering the monobehaviours that are referenced in the inspector of ApplicationController
        builder.RegisterComponent(_monoBehaviour1);
        builder.RegisterComponent(_monoBehaviour2);
        builder.RegisterComponent(_monoBehaviour3);

        // Registering a pure C# class as a singleton
        builder.Register<Class1>(Lifetime.Singleton);
        builder.Register<Class2>(Lifetime.Singleton);

        // Registering a pure c# class as implemented interfaces, that will use VContainer's own playerloop system.
        builder.RegisterEntryPoint<Class2>();   // same as -> builder.Register<Class2>(Lifetime.Singleton).AsImplementedInterfaces();
    }

    private void Start()
    {
        Container.Inject(_monoBehaviour3);          // manual injection of monobehaviours

        _monoBehaviour1.Run(MESSAGE);
        _monoBehaviour1.RunMonoBehaviour2(MESSAGE);

        _monoBehaviour2.RunClass1(MESSAGE);

        _monoBehaviour3.Run(MESSAGE);
        _monoBehaviour3.RunClass1(MESSAGE);

        _class1 = Container.Resolve<Class1>();
        _class1.InjectDependencies(_monoBehaviour1);
        _class1.Run(MESSAGE);
        _class1.RunMonoBehaviour1(MESSAGE);
    }
}
