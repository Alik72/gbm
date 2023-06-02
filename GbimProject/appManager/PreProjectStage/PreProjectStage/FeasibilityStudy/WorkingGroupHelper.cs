using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools;
using WindowsInput;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.IO;
using OpenQA.Selenium.Interactions;

namespace WebGbimTests
{
    public class WorkingGroupHelper : HelperBase
    {
        public WorkingGroupHelper(ApplicationManager manager) : base(manager)
        {
        }

        public WorkingGroupHelper InitChooset()
        {
            //Кнопка Выбрать
            Click(By.XPath("//div[@id='main-container']/div[2]/gb-core-layout/div/gb-second-layout/gb-third-layout/app-work-group-page/gb-workgroup-list/div/button[2]/span[2]"));
            return this;
        }
        public WorkingGroupHelper ChoosetСontractDevTEO()
        {
            InitTypeDocument();
            //Выбрать Договор разработки ТЭО
            Click(By.XPath("//*/text()[normalize-space(.)='Договор на разработку ТЭО']/parent::*"));
            return this;
        }
        public void InitTypeDocument()
        {
            // Нажать на тип документа
            Click(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Тип документа'])[1]/following::span[1]"));
        }
        public WorkingGroupHelper SubmitСontractDevTEO()
        {
            //Сохранить Договор разработки ТЭО
            Click(By.XPath("//div[3]/button/span"));
            return this;
        }
        public WorkingGroupHelper ChoosetPackageDocumentsTEO()
        {
            //Очистить поле поиска
            Click(By.XPath("//div/i"));
            
            InitTypeDocument();

            //Выбрать Пакет документа ТЭО
            Click(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Техническое задание на ТЭО'])[1]/following::span[1]"));
            return this;
        }
        public WorkingGroupHelper SubmitPackageDocumentsTEO()
        {
            //Сохранить  ТЭО
            Click(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Подписать документ в пакете ТЭО'])[3]/following::span[1]"));
            //Click(By.XPath("//div[4]/button/span"));
            return this;
        }
        public WorkingGroupHelper InitPackageDocumentsTEO()
        {
            //Кнопка Выбрать
            Click(By.XPath("//*[@id=\"main-container\"]//gb-workgroup-list//button[2]"));
            return this;
        }
        
    }
}
