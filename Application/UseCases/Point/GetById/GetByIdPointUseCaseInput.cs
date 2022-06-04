namespace Application.UseCases.Point.GetById
{
    public class GetByIdPointUseCaseInput
    {
        private const string collectionName = "POI/";

        public GetByIdPointUseCaseInput(int id)
        {
            Id = ConcatCollectionName(id);
        }

        public string Id { get; set; }

        private string ConcatCollectionName(int id)
        {
            return $"{collectionName}{id}";
        }
    }
}