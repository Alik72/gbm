using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) : base(manager)
        {
        }
        public NavigationHelper GoToProjectPage()
        {
            Click(By.XPath("//li[7]/a/span"));
            return this;
        }
        //перейти на Вид деятельности - Заказчик
        public NavigationHelper GoToTypeCustomer()
        {
            Click(By.XPath("//div[2]/div/h3"));
            return this;
        }
        public NavigationHelper GoToOneProject()
        {
            //Нажать на первую строку проекта 
            Click(By.XPath("//tr[1]/td[1]"));
            return this;
        }
        public NavigationHelper GoToPreProjectStage()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Предпроектная стадия']/parent::*"));
            return this;
        }
        public NavigationHelper GoToTabTEO()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Технико-экономическое обоснование']/parent::*"));
            return this;
        }
       public NavigationHelper GoToTabWorkGroup()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Состав рабочей группы']/parent::*"));
            return this;
        }

    }
}
