namespace IntroductionLinq.App.Enums
{
    /// <summary>
    /// Statut des commande
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Creation
        /// </summary>
        Creation = 1,

        /// <summary>
        /// Validation
        /// </summary>
        Validate = 2,

        /// <summary>
        /// En cours
        /// </summary>
        Processed = 3,

        /// <summary>
        /// Fini
        /// </summary>
        Finished = 4,
    }
}
