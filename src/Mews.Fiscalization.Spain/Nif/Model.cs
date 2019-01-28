using FuncSharp;

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
        public NifInfoEntry(string nif, string nombre)
        {
            Nif = nif;
            Nombre = nombre;
        }

        public string Nif { get; }

        public string Nombre { get; }
    }

    public class NifInfoResults
    {
        public NifInfoResults(string nif, string nombre, string result)
        {
            Nif = nif;
            Nombre = nombre;
            ResultMessage = result;
            Result = ResultMessage.Match(
                "Identificado", _ => NifSearchResult.Found,
                "No identificado", _ => NifSearchResult.NotFound,
                "No procesado", _ => NifSearchResult.NotProcessed,
                _ => NifSearchResult.Other
            );
        }

        public string Nif { get; }

        public string Nombre { get; }

        public NifSearchResult Result { get; }

        public string ResultMessage { get; }
    }

    public class Request
    {
        public Request(NifInfoEntry[] entries)
        {
            Entries = entries;
        }

        public NifInfoEntry[] Entries { get; }
    }

    public class Response
    {
        public Response(NifInfoResults[] results)
        {
            Results = results;
        }

        public NifInfoResults[] Results { get; }
    }
}