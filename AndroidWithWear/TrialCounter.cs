using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidWithWear {

	public class TrialCounter {

		public int Count { get; private set; } = 0;

		public void CountUp() => Count++;

		public void Reset() => Count = 0;

	}
}
