namespace GameFolders.Scripts.Abstraction_Architecture
{
    public interface IActionProvider
    {
        void Act(); // artık bu parametreyi almasına gerek yok. -->> Dictionary<Type, IStateProvider> stateProviders
    }
}