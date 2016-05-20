

namespace SimpleTeam.Command
{
    /**
    <summary>
    Команда исполняющая сценарную операцию.
    </summary>
    */
    public interface ICommand : ITypeID
    {
        void Do(IAllParameters parameter);
    }
}
