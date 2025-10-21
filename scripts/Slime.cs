using Godot;
using System;

public partial class Slime : Node2D
{
	int speed = 60;
	int direction = 1;
	RayCast2D rayCastRight;
	RayCast2D rayCastLeft;
	AnimatedSprite2D animatedSprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		rayCastRight = GetNode<RayCast2D>("RayCastRight");
		rayCastLeft = GetNode<RayCast2D>("RayCastLeft");
		animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}
	
	

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (rayCastRight.IsColliding())
		{
			direction = -1;
			animatedSprite.FlipH = true;
		}
		else if (rayCastLeft.IsColliding())
        {
			direction = 1;
			animatedSprite.FlipH = false;
        }

		float dt = (float)delta;
		Position = new Vector2(Position.X + direction*speed*dt, Position.Y);
    }
}
