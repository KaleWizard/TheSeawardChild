using Godot;
using System;

public partial class Sprite : Node2D
{
	float speed = 250f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 pos = Position;
		if (Input.IsActionPressed("move_right"))
		{
			pos += Vector2.Right * speed * (float)delta;
		}

        if (Input.IsActionPressed("move_left"))
        {
            pos += Vector2.Left * speed * (float)delta;
        }

        if (Input.IsActionPressed("move_up"))
        {
            pos += Vector2.Up * speed * (float)delta;
        }

        if (Input.IsActionPressed("move_down"))
        {
            pos += Vector2.Down * speed * (float)delta;
        }
        Position = pos;
	}
}
