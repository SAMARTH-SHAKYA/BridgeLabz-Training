public interface IPasswordCracker
{
    void GenerateAll(int length);
    bool CrackPassword(string target);
}
