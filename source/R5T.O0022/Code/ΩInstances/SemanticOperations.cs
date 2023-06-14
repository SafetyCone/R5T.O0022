using System;


namespace R5T.O0022
{
    public class SemanticOperations : ISemanticOperations
    {
        #region Infrastructure

        public static ISemanticOperations Instance { get; } = new SemanticOperations();


        private SemanticOperations()
        {
        }

        #endregion
    }
}
