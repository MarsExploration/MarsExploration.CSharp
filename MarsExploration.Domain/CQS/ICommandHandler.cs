namespace MarsExploration.Domain.CQS
{
    /// <summary>
    /// Abstração de ações do sistema que geram efeito colateral
    /// ( No caso da aplicação de exemplo da exploração de Marte, 
    ///   em questão de sistema, nenhum efeito colateral como por exemplo persistência em banco de dados é gerado,
    ///   porém me pareceu fazer mais sentido tratar a movimentação da sonda como um Command,
    ///   já que se fosse executado na prática, geraria um efeito colateral )
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface ICommandHandler<TCommand, TResult>
    {
        TResult Handle(TCommand command);
    }
}
