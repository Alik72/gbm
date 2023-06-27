using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class DevelopTEOHelper : HelperBase
    {
        public DevelopTEOHelper(ApplicationManager manager) : base(manager)
        {
        }

        public DevelopTEOHelper Сreation()
        {
            SleepSec(1);
            if (IsElementPresent(By.XPath("//a[@id='documentation']/span"), 0))
            {
                return this;
            }
            Click(By.XPath("//*/text()[normalize-space(.)='Создать пакет']/parent::*"));
            return this;

        }
        public DevelopTEOHelper FillDevelopTEOForm()
        {
            Document()
           .AddSectionDoc()
           .DocumentType()
           .AttachFileWindows(By.CssSelector("label.gb-file-loader-button"), "Открытие",
            "C:\\Users\\User\\Desktop\\Работа\\ГБИМ\\UK.pdf");
            return this;
        }

       

        private DevelopTEOHelper Document()
        {
            //нажать на кнопку Документ
            Click(By.XPath("//a[@id='documentation']/span"));
            return this;
        }
        private DevelopTEOHelper AddSectionDoc()
        {
            SleepSec (2);
            //нажать на кнопку Добавить документ к разделу
            Click(By.CssSelector("span.p-button-icon.uil.uil-file-plus"));
            return this;
        }
        private DevelopTEOHelper DocumentType()
        {
            //клик по полю Вид документа
            Click(By.XPath("//gb-selectbox/div/p-dropdown/div/span"));
            SleepSec(1);
            //Выбрать акт выбора участка
            Click(By.XPath("//li/span"));
            return this;
        }

        
    }
    }
