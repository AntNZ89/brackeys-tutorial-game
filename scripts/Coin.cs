using Godot;
using System;

public partial class Coin : Area2D
{
	private gamemanager gameManager;

	public override void _Ready()
	{
		gameManager = GetNode<gamemanager>("%GameManager");
		BodyEntered += OnBodyEntered;
	}
	
	private void OnBodyEntered(Node2D body)
	{
		GD.Print("YAY you collected a coin");
		gameManager.AddPoint();
		QueueFree();
    }




}
