using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace WebGbimTests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void Login(AccountDate account, string nameWindow)
        {
            //авторизация: логин+пароль

            Click(By.XPath("//div/button"));
            EZP(account, nameWindow);
        }
        public void Login()
        {
            //авторизация: логин+пароль

            Click(By.XPath("//div/button"));
            
        }
        


        public void Logout()
        {    //выход из профиля если залогинены
            if (IsLoggedOff().Equals(false))
            {
                try
                {
                    Click(By.XPath("//*/text()[normalize-space(.)='Выйти из системы']/parent::*"));
                }
                catch (Exception)
                {
                    Click(By.CssSelector("span.role.sub-title"));
                    Click(By.XPath("//*/text()[normalize-space(.)='Выйти']/parent::*"));
                }
            }
        }
        public bool IsLoggedOff()
        {    //проверка отображения элемента - Выйти из системы
           return IsElementPresent(By.Name("//*/text()[normalize-space(.)='Выберите сертификат']/parent::*"), 0);
         }

        // public bool IsLoggedIn(AccountDate account)
        // {    //проверка отображения имени залогиненного пользователя
        //     return IsLoggedIn()
        //          && GetLoggedUserName() == account.Username; //извлекает имя залогиненного пользователя
        //  }

        // public string GetLoggedUserName()
        //  {
        //      string text = wd.FindElement(By.CssSelector("div.login-container div.title")).Text;//в переменную text записать значение тега b 

        //      return text.Substring(1, text.Length - 2); // обрезаем значение из тега b в начале на -1  и в конце на -1 символ
         }
    }

