namespace Application.UseCases.User.Update
{
    public class UpdateUserUseCaseOutput
    {
        public UpdateUserUseCaseOutput(bool updated, string message)
        {
            Updated = updated;
            Message = message;
        }

        public bool Updated { get; set; }

        public string Message { get; set; }

        public static UpdateUserUseCaseOutput Ok() => new UpdateUserUseCaseOutput(true, "Atualizado com sucesso.");

        public static UpdateUserUseCaseOutput Fail() => new UpdateUserUseCaseOutput(false, "Erro ao atualizar.");
    }
}