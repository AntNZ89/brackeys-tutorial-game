using Godot;
using System;


public partial class Killzone : Area2D
{
    private Timer timer;

    public override void _Ready()
    {
        timer = GetNode<Timer>("Timer");
        timer.Timeout += OnTimeOut;
        BodyEntered += OnBodyEntered;
    }

    private void OnBodyEntered(Node2D body)
    {
        GD.Print("You died!");
        timer.Start();
    }

    private void OnTimeOut()
    {
        GetTree().ReloadCurrentScene();
    }



}
