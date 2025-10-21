using Godot;
using System;

public partial class gamemanager : Node
{

	int score = 0;
	private Label Score;

    public override void _Ready()
    {
		Score = GetNode<Label>("%Score");
		Score.Text = "score: " + score;
    }


	public void AddPoint()
    {
		score++;
		Score.Text = "score: " + score;
    }



	
}
