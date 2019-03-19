using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLibrary {
    /// <summary>
    /// The different types of tasks.
    /// </summary>
    public enum TaskType {
        /// <summary>
        /// Tasks in research phase
        /// </summary>
        RESEARCH,

        /// <summary>
        /// Tasks in requirements phase
        /// </summary>
        REQUIREMENTS,

        /// <summary>
        /// Tasks in design phase
        /// </summary>
        DESIGN,

        /// <summary>
        /// Tasks in implementation phase
        /// </summary>
        IMPLEMENTATION,

        /// <summary>
        /// Tasks in testing phase
        /// </summary>
        TESTING
    }
}
