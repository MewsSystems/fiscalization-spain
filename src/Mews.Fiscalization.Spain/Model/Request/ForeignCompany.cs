using FuncSharp;
using Mews.Fiscalization.Core.Model;
using System;

namespace Mews.Fiscalization.Spain.Model.Request
{
    public sealed class ForeignCompany
    {
        public ForeignCompany(LimitedString120 name, ResidenceCountryIdentificatorType identificatiorType, LimitedString1to20 id, Country country = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Country = country.ToOption();
            IdentificatorType = identificatiorType;
            Id = id ?? throw new ArgumentNullException(nameof(id));

            if (!IsValid(id, name, country))
            {
                throw new ArgumentException($"{nameof(country)} has to be specified if {nameof(id)} doesn't start with country code.");
            }
        }

        public LimitedString120 Name { get; }

        public IOption<Country> Country { get; }

        public ResidenceCountryIdentificatorType IdentificatorType { get; }

        public LimitedString1to20 Id { get; }

        public static bool IsValid(LimitedString1to20 id, LimitedString120 name, Country country = null)
        {
            if (country == null)
            {
                if (id.Value.Length < 2)
                {
                    return false;
                }

                var countryCode = id.Value.Substring(0, 2);
                return Core.Model.Country.GetByCode(countryCode).NonEmpty;
            }
            return id != null && name != null;
        }
    }
}
