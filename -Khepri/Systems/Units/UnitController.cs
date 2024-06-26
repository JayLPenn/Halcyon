using Godot;
using System;

namespace Halcyon.Khepri.Units
{
	public partial class UnitController : Node
	{
		/// <summary> The current player-controlled unit. </summary>
		[Export] private Unit _playerUnit;
		
		// Called when the node enters the scene tree for the first time.
		public override void _Ready()
		{
		}

		// Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _Process(double delta)
		{
		}

		public override void _Input(InputEvent inputEvent)
		{
			Vector3I direction = new Vector3I();
			
			if (InputMap.ActionHasEvent("action_move_north", inputEvent))
			{
				direction = new Vector3I(0, 0, -1);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_east"))
			{
				direction = new Vector3I(1, 0, 0);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_south"))
			{
				direction = new Vector3I(0, 0, 1);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_west"))
			{
				direction = new Vector3I(-1, 0, 0);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_northeast"))
			{
				direction = new Vector3I(1, 0, -1);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_southeast"))
			{
				direction = new Vector3I(1, 0, 1);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_southwest"))
			{
				direction = new Vector3I(-1, 0, 1);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_northwest"))
			{
				direction = new Vector3I(-1, 0, -1);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_up"))
			{
				direction = new Vector3I(0, 1, 0);
			}
			
			if (InputMap.EventIsAction(inputEvent, "action_move_down"))
			{
				direction = new Vector3I(0, -1, 0);
			}

			if (direction != Vector3I.Zero)
			{
				_playerUnit.Move(direction);
			}
		}
	}
}
