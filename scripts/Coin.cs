using Godot;
using System;

public partial class Coin : Area2D
{
	private gamemanager gameManager;
	private AnimationPlayer animation;

	public override void _Ready()
	{
		animation = GetNode<AnimationPlayer>("AnimationPlayer");
		gameManager = GetNode<gamemanager>("%GameManager");
		BodyEntered += OnBodyEntered;
	}
	
	private void OnBodyEntered(Node2D body)
	{
		gameManager.AddPoint();
		animation.Play("pickup");
    }




}
