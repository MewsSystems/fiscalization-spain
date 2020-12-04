using FuncSharp;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class WithTaxItem
    {
        public WithTaxItem(TransactionType transactionType, VATBreakdown[] vatBreakdowns)
        {
            TransactionType = transactionType;
            VatBreakdowns = vatBreakdowns.ToNonEmptyOption().Where(b => b.Length < 7).GetOrNull() ?? throw new Exception("The amount of tax items must be between 1 and 6.");
        }

        public TransactionType TransactionType { get; }

        public VATBreakdown[] VatBreakdowns { get; }
    }
}
