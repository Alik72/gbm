using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        public NavigationHelper (ApplicationManager manager, string baseURL) : base(manager) 
        {
            this.baseURL = baseURL;
        }
    public NavigationHelper OpenProjectPage()
        {
            if(wd.Url == baseURL + "main/projects")
            {
                return this;
            }
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
        public NavigationHelper GoToDevelopProjectPage()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Разработать проект']/parent::*"));
            return this;
        }
        public NavigationHelper GoToTabPreparBasisDevTEO()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Подготовка основания разработки ТЭО']/parent::*"));
            return this;
        }
        public NavigationHelper GoToTabInitData()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Исходные данные']/parent::*"));
            return this;
        }
        public NavigationHelper GoToTabDevelopmentTEO()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Разработка ТЭО']/parent::*"));
            return this;
        }

        public NavigationHelper GoToPreProjectStageTEO()
        {
            if(IsElementPresent(By.XPath("//*/text()[normalize-space(.)='Технико-экономическое обоснование']/parent::*"), 0))
             {
                return this;
             }
              GoToTypeCustomer()
             .OpenProjectPage()
             .GoToOneProject()
             .GoToPreProjectStage()
             .GoToTabTEO();
            return this;
        }

        public NavigationHelper GoToTabKVE() {
            
            //Перейти в пает КВЭ
            Click(By.XPath("//*/text()[normalize-space(.)='КВЭ']/parent::*"));
           
            return this;
        }

        public NavigationHelper GoToTabPackageDocument() {
            Click(By.XPath("//*/text()[normalize-space(.)='Пакет документов']/parent::*"));
            return this;
        }
        public NavigationHelper GoToTabApplicationKVE()
        {
            Click(By.XPath("//*/text()[normalize-space(.)='Заявка на КВЭ']/parent::*"));
            return this;
        }

        public NavigationHelper GoToOneApplicKVE()
        {
            //Нажать на первую заявку в таблице КВЭ
           // Click(By.XPath("//*[@id=\"pr_id_36-table\"]/tbody/tr"));
            Click(By.CssSelector("tr.p-element.table-item.p-selectable-row.ng-star-inserted"));
            return this;
        }

    }
}
