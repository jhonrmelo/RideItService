namespace Application.UseCases.Route.Get
{
    public class GetRouteUseCaseInput
    {
        private const string collectionName = "POI/";

        public string From { get; set; }
        public string To { get; set; }
        public string Preference { get; set; }

        public GetRouteUseCaseInput(int from, int to, string preference)
        {
            From = ConcatCollectionName(from);
            To = ConcatCollectionName(to);
            Preference = preference;
        }

        private string ConcatCollectionName(int id)
        {
            return $"{collectionName}{id}";
        }
    }
}