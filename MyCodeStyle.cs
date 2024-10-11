public class MyCodeStyle : MonoBehavior
{
    // Constants: UpperCase SnakeCase
    public const int MY_CONSTANT_FIELD = 56;

    // Properties: PascalCase
    public static MyCodeStyle Instance { get; private set; }

    // Events: PascalCase
    private event EventHandler OnSomethingHappend;

    // Fields: camelCase
    private float memberVariable;

    // Function Names: PascalCase
    private void Awake() {
        Instance = this;

        DoSomething(10f);
    }

    // Function Params: camelCase
    private void DoSomething(float time) {
        // Do something...
        memberVariable = time + time.deltaTime;
        if (memberVariable > 0) {
            // Do something else...
        }
    }
}