using Godot;

namespace NeedleConsole;

public partial class HelloWorld : Node
{
    public override void _Ready()
    {
        GD.Print("Hello World");
        base._Ready();
    }
}