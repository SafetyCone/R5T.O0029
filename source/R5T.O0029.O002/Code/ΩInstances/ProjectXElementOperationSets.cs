using System;


namespace R5T.O0029.O002
{
    public class ProjectXElementOperationSets : IProjectXElementOperationSets
    {
        #region Infrastructure

        public static IProjectXElementOperationSets Instance { get; } = new ProjectXElementOperationSets();


        private ProjectXElementOperationSets()
        {
        }

        #endregion
    }
}
