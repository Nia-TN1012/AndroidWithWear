using System;
using System.Collections.Generic;
using System.Text;

// Note: Code placed on this shared project, can be used for both mobile and wearable projects.

namespace AndroidWearApp2 {

	/// <summary>
	///		Simple counter
	/// </summary>
	public class TrialCounter {

		/// <summary>
		///		Gets current count.
		/// </summary>
		public int Count { get; private set; } = 0;

		/// <summary>
		///		Count up.
		/// </summary>
		public void CountUp() => Count++;

		/// <summary>
		///		Resets counter.
		/// </summary>
		public void Reset() => Count = 0;

	}
}
