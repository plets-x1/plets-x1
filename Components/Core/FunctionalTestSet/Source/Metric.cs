using System.Collections.Generic;

namespace Plets.Modeling.TestSuitStructure {
    /// <summary>
    /// Class that represents a generic Metric
    /// </summary>
    public class Metric {
        private List<Counter> counters;
        /// <summary>
        /// Counter list.
        /// </summary>
        public List<Counter> Counters {
            get { return counters; }
            set { counters = value; }
        }

        /// <summary>
        /// Operational system enum list
        /// </summary>
        public enum OperationalSystem {
            Windows,
            Linux,
            Unix,
            MacOS
        }

        private OperationalSystem os;
        /// <summary>
        /// OS.
        /// </summary>
        public OperationalSystem OS {
            get { return os; }
            set { os = value; }
        }

        private string name;
        /// <summary>
        /// Metric name.
        /// </summary>
        public string Name {
            get { return name; }
            set { name = value; }
        }
    }
}