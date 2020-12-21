# SeleniumHW

Для запуска тестов необходимо создать C# Console App( .Net Framework) проект в Visual Studio и установить следующие NuGet пакеты:
Selenium.WebDriver,
NUnitTestAdapter,
NUnit,
Microsoft.NET.Test.Sdk.
Потом добавить к созданному решению файл Testsfrom1to8.cs.
Кроме этого нужно скачать файл operadriver.exe по ссылке https://github.com/operasoftware/operachromiumdriver/releases (chromedriver.exe по ссылке https://chromedriver.chromium.org/downloads) и поместить его в папку которая добавлена в PATH (либо же в любую папку но тогда в файлe Testsfrom1to8.cs
в строке с созданием драйвера: driver = new OperaDriver(); нужно будет явно указать путь хранения operadriver.exe(chromedriver.exe) т.е driver = new OperaDriver("путь к файлу operadriver.exe");)
После этого можно запускать тесты в Test Explorer.
