namespace Application.UseCases.Segment.GetById
{
    public class GetByIdSegmentUseCaseInput
    {
        private const string collectionName = "Segment/";

        public GetByIdSegmentUseCaseInput(int id)
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