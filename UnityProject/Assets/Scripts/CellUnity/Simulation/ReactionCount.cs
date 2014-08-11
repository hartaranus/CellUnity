using UnityEngine;
using System.Collections;
using CellUnity.Reaction;

namespace CellUnity.Simulation
{
	public class ReactionCount
	{
		public ReactionCount(ReactionType reactionType, long count)
		{
			this.ReactionType = reactionType;
			this.Count = count;
		}
		
		public ReactionType ReactionType { get; private set; }
		public long Count { get; private set; }
	}
}