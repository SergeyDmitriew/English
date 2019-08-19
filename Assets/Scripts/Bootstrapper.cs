using Engine.Mediators;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private MainInfrastructure infrastructure;
    private UnityEventMediator unityEventMediator;

    // Use this for initialization
    private void Awake ()
    {
        var monoStorage = FindObjectOfType<MonoBehaviourStorage> ();

        infrastructure = new MainInfrastructure (monoStorage);
        unityEventMediator = new UnityEventMediator (infrastructure);
    }

    // Use this for initialization
    private void Start ()
    {
        unityEventMediator.Initialize ();
    }

    // Update is called once per frame
    private void Update ()
    {
        unityEventMediator.Update (Time.deltaTime);
    }

    private void OnDestroy ()
    {
        unityEventMediator.Dispose ();
    }
}