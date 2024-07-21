using Godot;

namespace PipeWall;

/// <summary>
/// template
/// </summary>
public partial class MainMenu : Control
{
  // Signals

  // Exports

  // Public Fields

  // Backing Fields

  // Private Fields

  // Constructor

  // Lifecycle Hooks

  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {
    GD.Print("MainMenu Ready");
  }

  // Public Functions
  public void OnStartPressed()
  {
    GD.Print("Start Pressed");
  }

  public void OnQuitPressed()
  {
    GetTree().Root.PropagateNotification((int)NotificationWMCloseRequest);
    GetTree().Quit();
  }

  // Private Functions
}
