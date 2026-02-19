using System.Threading.Tasks;

namespace AddressBookSystem;

public class Program
{
    public static async Task Main(string[] args)
    {
        AddressBookMenu CallMenu = new AddressBookMenu();
        await CallMenu.MenuAsync();
    }
}