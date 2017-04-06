using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba2
{
    class Measurement
    {
        public int Id { get; private set; }
        public double Value { get; private set; }
        public DateTime Timestamp { get; private set; }

        public Measurement(int id, double value, DateTime timestamp)
        {
            this.Id = id;
            this.Value = value;
            this.Timestamp = timestamp;
        }

        public override string ToString()
        {
            return String.Format("Meas {0}, Val: {1}, at {2}", this.Id, this.Value, this.Timestamp);
        }
    }
}
