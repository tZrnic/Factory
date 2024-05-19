using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program()
{
    public static void Main()
    {
        LoginPageFactory loginPageFactory = new ChromeLoginPageFactory();

        LoginPage loginPage = loginPageFactory.CreatePage();

        loginPage.passwordInput().Click();
        loginPage.usernameInput().Click();
        loginPage.loginButton().Click();
    }
}