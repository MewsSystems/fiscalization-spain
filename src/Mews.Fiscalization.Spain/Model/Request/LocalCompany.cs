using Mews.Fiscalization.Core.Model;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class LocalCompany
    {
        public LocalCompany(LimitedString120 name, TaxpayerIdentificationNumber taxpayerNumber)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            TaxpayerNumber = taxpayerNumber ?? throw new ArgumentNullException(nameof(taxpayerNumber));
        }

        public LimitedString120 Name { get; }

        public TaxpayerIdentificationNumber TaxpayerNumber { get; }
    }
}
