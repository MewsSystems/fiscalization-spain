namespace Mews.Fiscalization.Spain.Model
{
    public enum InvoiceRegisterResult
    {
        /// <summary>
        /// CORRECTO
        /// </summary>
        Accepted,

        /// <summary>
        /// ACEPTADOCONERRORES
        /// </summary>
        AcceptedWithErrors,

        /// <summary>
        /// INCORRECTO
        /// </summary>
        Rejected
    }
}
