using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebGbimTests
{
    public class PackageKVECreateHelper : HelperBase
    {
        public PackageKVECreateHelper(ApplicationManager manager) : base(manager)
        {
        }
        public PackageKVECreateHelper InitСreation()
        {
           if (IsElementPresent(By.XPath("//*/text()[normalize-space(.)='Развернуть']/parent::*"), 5))
            {
                return this;
            }
            Click(By.XPath("//*/text()[normalize-space(.)='Добавить документы']/parent::*"));
            return this;
        }
        public PackageKVECreateHelper FillPackageKVEForm()
        {
            //SleepSec(1);
            
            for (int i = 1; i < 3; i++)
            {
                // нажать на кнопку Редактировать
                Click(By.XPath(String.Format("//div[@id='main-container']//gb-document-package-tree[{0}]//button[2]/span[2]", i)));
                SleepSec(2);
                // нажать на кнопку Выделить все
                Click(By.XPath("//*/text()[normalize-space(.)='Выделить все']/parent::*"));
                SleepSec(2);
                // нажать на кнопку Сохранить
                Click(By.XPath("//*/text()[normalize-space(.)='Сохранить']/parent::*"));
                SleepSec(3);
            }
            
            return this;
        }
       
    }
}
