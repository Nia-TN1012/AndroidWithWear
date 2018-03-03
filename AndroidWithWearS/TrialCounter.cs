using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidWithWearS {

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
