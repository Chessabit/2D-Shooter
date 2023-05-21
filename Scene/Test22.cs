using Godot;
using System;

public partial class Test22 : Godot.Node2D
{
	Control Background;
	public int Score = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Background = GetNode<Control>("Background");
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	var direction_x = Input.GetAxis("Left", "Right");
	var direction_y = Input.GetAxis("Up", "Down");
	var backgroundNode = Background.GetNode<Label>("Label2");
	GD.Print (backgroundNode == null);
	backgroundNode.Set("text", $"Axis:Computed{direction_x} : {direction_y}");
	}
}
