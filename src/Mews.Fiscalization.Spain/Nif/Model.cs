using System.Collections.Generic;
using System.Linq;
using FuncSharp;
using Mews.Fiscalization.Core.Model;

namespace Mews.Fiscalization.Spain.Nif
{
    public enum NifSearchResult
    {
        Found,
        FoundButNifModifiedByServer,
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
            Check.Condition(taxpayerNumber.Country.Alpha2Code == Countries.Spain.Alpha2Code, "Country must be Spain.");

            TaxpayerNumber = taxpayerNumber;
            Name = name;
        }

        public TaxpayerIdentificationNumber TaxpayerNumber { get; }

        public string Name { get; }
    }

    public class NifInfoResults
    {
        public NifInfoResults(string taxId, string name, NifSearchResult result, string resultMessage = null)
        {
            TaxId = taxId;
            Name = name;
            Result = result;
            ResultMessage = resultMessage.ToOption();
        }

        public string TaxId { get; }

        public string Name { get; }

        public NifSearchResult Result { get; }

        public IOption<string> ResultMessage { get; }
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