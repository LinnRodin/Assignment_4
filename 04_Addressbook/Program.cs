using _04_Addressbook.Services;

var menuServices = new MenuServices();
menuServices.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

while (true)
{
    Console.Clear();
    menuServices.OptionsMenu();
}


