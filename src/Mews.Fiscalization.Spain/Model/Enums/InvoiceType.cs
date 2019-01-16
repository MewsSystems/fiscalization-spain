namespace Mews.Fiscalization.Spain.Model
{
    public enum InvoiceType
    {
        /// <summary>
        /// F1
        /// </summary>
        Invoice,

        /// <summary>
        /// F2
        /// </summary>
        SimplifiedInvoice,

        /// <summary>
        /// R1
        /// </summary>
        CorrectedInvoice,

        /// <summary>
        /// R2
        /// </summary>
        CorrectedInvoice2,

        /// <summary>
        /// R3
        /// </summary>
        CorrectedInvoice3,

        /// <summary>
        /// R4
        /// </summary>
        CorrectedInvoice4,

        /// <summary>
        /// R5
        /// </summary>
        CorrectedInvoiceInSimplifiedInvoices,

        /// <summary>
        /// F3
        /// </summary>
        InvoiceIssuedToReplaceSimplifiedInvoices,

        /// <summary>
        /// F4
        /// </summary>
        InvoiceSummaryEntry
    }
}
