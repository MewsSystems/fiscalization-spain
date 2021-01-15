using System.Collections.Generic;
using System.Linq;
using FuncSharp;
using Mews.Fiscalization.Core.Model;

namespace Mews.Fiscalization.Spain.Nif
{
    public enum NifSearchResult
    {
        Found,
        NotFound,
        NotProcessed,
        Other
    }

    public class NifInfoEntry
    {
        public NifInfoEntry(TaxpayerIdentificationNumber taxpayerNumber, string name)
        {
            Check.IsNotNull(taxpayerNumber, nameof(taxpayerNumber));
            Check.IsNotNull(name, nameof(name));
            Check.Condition(taxpayerNumber.Country == Countries.Spain, "Country must be Spain.");

            TaxpayerNumber = taxpayerNumber;
            Name = name;
        }

        public TaxpayerIdentificationNumber TaxpayerNumber { get; }

        public string Name { get; }
    }

    public class NifInfoResults
    {
        public NifInfoResults(string taxId, string name, string result)
        {
            TaxId = taxId;
            Name = name;
            ResultMessage = result;
            var lowerCaseResult = ResultMessage?.ToLowerInvariant();
            Result = lowerCaseResult.Match(
                "identificado", _ => NifSearchResult.Found,
                "no identificado", _ => NifSearchResult.NotFound,
                "no procesado", _ => NifSearchResult.NotProcessed,
                _ => NifSearchResult.Other
            );
        }

        public string TaxId { get; }

        public string Name { get; }

        public NifSearchResult Result { get; }

        public string ResultMessage { get; }
    }

    public class Request
    {
        public Request(IEnumerable<NifInfoEntry> entries)
        {
            Entries = entries.ToList();
        }

        public IEnumerable<NifInfoEntry> Entries { get; }
    }

    public class Response
    {
        public Response(IEnumerable<NifInfoResults> results)
        {
            Results = results.ToList();
        }

        public IEnumerable<NifInfoResults> Results { get; }
    }
}