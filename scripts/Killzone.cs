using Godot;
using System;


public partial class Killzone : Area2D
{
    private Timer timer;
    public override void _Ready()
    {
        timer = GetNode<Timer>("Timer");
        BodyEntered += OnBodyEntered;
        timer.Timeout += OnTimeout;
    }

    private void OnBodyEntered(Node2D body)
    {
        GD.Print("You died!");
        Engine.TimeScale = 0.3;
        timer.Start();
        body.GetNode<CollisionShape2D>("CollisionShape2D").QueueFree();
    }

    private void OnTimeout()
    {
        Engine.TimeScale = 1;
        GetTree().ReloadCurrentScene();
    }




}
