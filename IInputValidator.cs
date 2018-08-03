namespace Monk_github
{
    public interface IInputValidator
    {
        bool IsNumberOfMonkSuplimentsValid();
        bool IsValueOfSuplimentsValid(string[] sup);
        bool IsNuberOfFruitsValid();
        bool IsNumberOfSuplimentsValid(int index);
        // bool IsValueOfSuplimentsValid(int index);
    }
}