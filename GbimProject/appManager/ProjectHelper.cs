using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
    public class ProjectHelper : HelperBase
    {
 
        public ProjectHelper(ApplicationManager manager) : base(manager)
        {
        }
        public ProjectHelper Create(ProjectDate project)
        {
            InitProjectСreation()
           .FillProjectForm(project)
           .SubmitProjectСreation();
            return this;
        }

        public ProjectHelper InitProjectСreation()
        {
            Click(By.XPath("//div[@id='main-container']/div[2]/app-list/div/g-table/div/div/div/button/span[2]"));
            return this;
        }
        public ProjectHelper FillProjectForm(ProjectDate date)
        {
            Type(By.XPath("//input[@type='text']"), date.ProjectCode);
            Click(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div"));
            Click(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div"));
            Type(By.XPath("//*[@id=\"main-container\"]/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[1]/gb-localizable-textarea/gb-textarea[1]/div/div[1]/textarea"), date.NameRus);
            Type(By.XPath("//*[@id=\"main-container\"]/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[1]/gb-localizable-textarea/gb-textarea[2]/div/div[1]/textarea"), date.NameKaz);
            Type(By.XPath("//*[@id=\"main-container\"]/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[1]/gb-localizable-textarea/gb-textarea[3]/div/div[1]/textarea"), date.NameEng);
            ClickSendKeys(By.XPath("//input[@type='search']"), date.SourceFinancing);
            Thread.Sleep(1000);
            Type(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[2]/gb-localizable-textarea/gb-textarea[2]/div/div/textarea"), date.ShortDescriptionKaz);
            Type(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[2]/gb-localizable-textarea/gb-textarea/div/div/textarea"), date.ShortDescriptionRus);
            Type(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[2]/gb-localizable-textarea/gb-textarea[3]/div/div/textarea"), date.ShortDescriptionEng);
            ClickSendKeys(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[3]/gb-autocomplete-selectbox/div/p-autocomplete/span/input"), date.TypeConstruction);
            Thread.Sleep(1000);
            Type(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[3]/gb-localizable-textarea/gb-textarea[2]/div/div/textarea"), date.DetailedDescriptionKaz);
            ClickSendKeys(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[4]/gb-autocomplete-selectbox/div/p-autocomplete/span/input"), date.ConstructionObject);
            Thread.Sleep(1000);
            Type(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[3]/gb-localizable-textarea/gb-textarea[3]/div/div/textarea"), date.DetailedDescriptionEng);
            Type(By.XPath("//div[@id='main-container']/div[2]/gb-edit-project/div/gb-view/div/form/div[2]/div/div[3]/gb-localizable-textarea/gb-textarea/div/div/textarea"), date.DetailedDescriptionRus);

            return this;
        }
        public ProjectHelper SubmitProjectСreation()
        {
            DoubleClick(By.XPath("//*[@id=\"main-container\"]//div[1]/div[2]/div/button/span[2]"));
            return this;
                }

        
            public ProjectHelper InitProjectUpdate()
        {
            //Нажать на кнопку Редактировать
            Click(By.XPath("//*/text()[normalize-space(.)='Редактировать']/parent::*"));
            return this;
        }
    }
}
