using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class AppKVECreateHelper : HelperBase
    {
        public AppKVECreateHelper(ApplicationManager manager) : base(manager)
        {
        }

        public AppKVECreateHelper InСreation()
        {
      
            Submit();
            return this;
        }

        public AppKVECreateHelper FillAppKVEForm()
        {
            //клик по полю Экспертиза рассмотрения
            DoubleClick(By.XPath("//p-dropdown/div/span"));
            SleepSec(1);
            //Выбрать Экспертизы рассмотрения
            String nameElement = "Республиканское государственное предприятие на праве хозяйственного ведения \"Государственная вневедомственная экспертиза проектов\" Комитета по делам строительства и жилищно-коммунального хозяйства Министерства индустрии и инфраструктурного развития Республики Казахстан (РГП \"Госэкспертиза\")";
            SelectElementList(By.CssSelector("li.p-dropdown-item"), nameElement);
           
            return this;
        }

        public AppKVECreateHelper SubmitAppKVE()
        {
            //клик по кнопке Создать
            Click(By.XPath("//*/text()[normalize-space(.)='Создать']/parent::*"));
            return this;
        }
        public AppKVECreateHelper SubmitForReviewKVE()
        {
            //клик по кнопке Отправить на рассмотрение заявку на КВЭ
            Click(By.XPath("//*/text()[normalize-space(.)='Отправить на рассмотрение']/parent::*"));
            return this;
        }

        


    }
}
