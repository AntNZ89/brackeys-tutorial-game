using Godot;
using System;

public partial class Coin : Area2D
{

	public override void _Ready()
	{
		BodyEntered += OnBodyEntered;
	}
	
	private void OnBodyEntered(Node2D body)
	{
		GD.Print("YAY you collected a coin");
		QueueFree();
    }




}
