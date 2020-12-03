using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class Header
    {
        public Header(LocalCompany company, CommunicationType communicationType)
        {
            Company = company ?? throw new ArgumentNullException(nameof(company));
            CommunicationType = communicationType;
        }

        public LocalCompany Company { get; }

        public CommunicationType CommunicationType { get; }
    }
}
