using System;
using Godot;

namespace Halcyon.Khepri.Units
{
	public partial class Unit : CharacterBody3D
	{
		/// <summary> The unit's sprite. </summary>
		[ExportGroup("Nodes")]
		[Export] private Sprite3D _sprite;
	
		/// <summary> The unit's collision area. </summary>
		[Export] private CollisionShape3D _collisionShape;

		/// <summary> The node to use for general-purpose ray casting. </summary>
		[Export] private RayCast3D _rayCaster;
		
		//	-------------------------------------------------------------------------------------------
		//	-------------------------------------------------------------------------------------------
	
		// Called when the node enters the scene tree for the first time.
		public override void _Ready()
		{
		}

		// Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _Process(double delta)
		{
		}

		public void Move(Vector3I relativeLocation)
		{
			KinematicCollision3D collision = MoveAndCollide(relativeLocation);
			GlobalPosition = new Vector3(
				(float)Math.Round(GlobalPosition.X, 0), 
				(float)Math.Round(GlobalPosition.Y, 0),
				(float)Math.Round(GlobalPosition.Z, 0));
			
			//GD.Print($"Moved: {test.GetCollider()}");
			//GD.Print($"New Location: {GlobalPosition}");
		}
	}
}