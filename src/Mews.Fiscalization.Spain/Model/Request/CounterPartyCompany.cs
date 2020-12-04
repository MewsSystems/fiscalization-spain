using FuncSharp;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class CounterPartyCompany : Coproduct2<LocalCompany, ForeignCompany>
    {
        public CounterPartyCompany(LocalCompany companyTitle)
            : base(companyTitle)
        {
            if (companyTitle == null)
            {
                throw new ArgumentNullException(nameof(companyTitle));
            }
        }

        public CounterPartyCompany(ForeignCompany foreignCompany)
            : base(foreignCompany)
        {
            if (foreignCompany == null)
            {
                throw new ArgumentNullException(nameof(foreignCompany));
            }
        }
    }
}
