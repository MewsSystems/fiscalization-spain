using Mews.Fiscalization.Core.Model;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class LocalCompany
    {
        public LocalCompany(LimitedString120 name, TaxpayerIdentificationNumber taxpayerIdentificationNumber)
        {
            Name = Check.IsNotNull(name, nameof(name));
            TaxpayerIdentificationNumber = Check.IsNotNull(taxpayerIdentificationNumber, nameof(taxpayerIdentificationNumber));
        }

        public LimitedString120 Name { get; }

        public TaxpayerIdentificationNumber TaxpayerIdentificationNumber { get; }
    }
}
