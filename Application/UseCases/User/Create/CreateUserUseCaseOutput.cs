namespace Application.UseCases.User.Create
{
    public class CreateUserUseCaseOutput
    {
        public CreateUserUseCaseOutput(bool inserted)
        {
            Inserted = inserted;
        }

        public bool Inserted { get; set; }

        public static CreateUserUseCaseOutput Ok() => new CreateUserUseCaseOutput(inserted: true);

        public static CreateUserUseCaseOutput Fail() => new CreateUserUseCaseOutput(inserted: false);
    }
}