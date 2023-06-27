using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{

    public class InitDataHelper : HelperBase
    {
        public InitDataHelper(ApplicationManager manager) : base(manager)
        {
        }

        public InitDataHelper InitСreation()
        {
            SleepSec(1);
            if (IsElementPresent(By.XPath("//*/text()[normalize-space(.)='Добавить документ']/parent::*"), 0))
            { 
               return this;
            }
            Click(By.XPath("//*/text()[normalize-space(.)='Создать пакет']/parent::*"));
            return this;
        }
        public InitDataHelper FillInitDataForm()
        {
                 AddDocument()
                .DocumentType()
                .AttachFileWindows(By.CssSelector("label.gb-file-loader-button"), "Открытие",
                 "C:\\Users\\User\\Desktop\\Работа\\ГБИМ\\UK.pdf");
            
            return this;
        }
        public InitDataHelper AddDocument()
        {
            SleepSec(2);
            Click(By.CssSelector("span.p-button-icon.uil.uil-file-plus"));
            return this;
        }
       
        public InitDataHelper DocumentType()
        {
            SleepSec(2);
            //клик по полю Вид документа
            Click(By.XPath("//p-dropdown/div/span"));
            SleepSec(1);
            //Выбрать Вспомогательные материалы
            Click(By.XPath("//*/text()[normalize-space(.)='Вспомогательные материалы']/parent::*"));
            return this;
        }
      

        public InitDataHelper SubmitInitDataСreation()
        {
            // нажать на кнопку создать
            Click(By.XPath("//*/text()[normalize-space(.)='Создать']/parent::*"));
            SleepSec(2);
            //обновить страницу
            wd.Navigate().Refresh();
            return this;
        }
         
        
    }
}
