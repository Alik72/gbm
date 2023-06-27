using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using WindowsInput;

namespace WebGbimTests
{
    public class HelperBase
    {
        public IWebDriver wd;
        public ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            wd = manager.Driver;
            this.manager = manager;
        }

        public void DoubleClick(By locator)
        {
            IWebElement element = wd.FindElement(locator);
            element.Click();
            element.Click();
        }
        public void Click(By locator)
        {
            wd.FindElement(locator).Click();
        }
        public void ClickSendKeys(By locator, String type)
        {
            wd.FindElement(locator).Click();
            wd.FindElement(locator).SendKeys(type);
        }
        public void Type(By locator, String type)
        {
            Click(locator);
            wd.FindElement(locator).Clear();
            wd.FindElement(locator).SendKeys(type);
        }
        public static void SleepSec(int s)
        {
            Thread.Sleep(s * 1000);
        }
        public bool IsElementPresent(By by, int seconds)
        {
            try
            {
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
                wd.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            finally 
            {
                wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
            }
        }
        public void SaveTextToFile(string filepath, string text)
        {
            try
            {
                //Передайте путь к файлу и имя файла конструктору 
                StreamWriter sw = new StreamWriter(filepath);
                //Напишите строку текста
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
        public int CountCreatedProjects(int sleep)
        {
            
            Thread.Sleep(sleep);
            String[] text = wd.FindElement(By.CssSelector("span.p-paginator-current.ng-star-inserted"))
                             .GetAttribute("textContent").Split(" ");
            return Int32.Parse(new Regex(@"\D").Replace(text[2], ""));
        }
        public bool FindWindow(string nameWindow)
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string? sClassName, string nameWindow);
            IntPtr thisWindow = FindWindow(null, nameWindow);
            return (int)thisWindow > 0;

        }
        public void WaitWindow(string nameWindow)
        {
            bool windowPresent;
            //ожидание 15 секунд 
            for (int i = 0; i < 30; i++)
            {
                windowPresent = FindWindow(nameWindow);
                if (windowPresent)
                {
                    return;
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
            throw new Exception("Не нашел окно виндовс");
        }
        
        public void unhide(WebDriver driver, WebElement element)
        {
            String script = "arguments[0].style.opacity=1;"
              + "arguments[0].style['transform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['MozTransform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['WebkitTransform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['msTransform']='translate(0px, 0px) scale(1)';"
              + "arguments[0].style['OTransform']='translate(0px, 0px) scale(1)';"
              + "return true;";
            ((IJavaScriptExecutor)driver).ExecuteScript(script, element);
        }

        public void attachFile(WebDriver driver, By locator, String file)
        {
            WebElement input = (WebElement)driver.FindElement(locator);
            unhide(driver, input);
            input.SendKeys(file);
        }
        public void AttachFileWindows(By locator, string nameWindow,  String filePath)
        {
            Click(locator);
            TextEntryWindows(nameWindow, filePath);
            SleepSec(2);
        }
        public void TextEntryWindows(string nameWindow, String filePath)
        {
            WaitWindow(nameWindow);
            InputSimulator sim = new InputSimulator();
            Thread.Sleep(500);
            sim.Keyboard.TextEntry(filePath);
            Thread.Sleep(1000);
            // submit enter 
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }
        public HelperBase Submit()
        {
            // нажать на кнопку создать
            Click(By.XPath("//*/text()[normalize-space(.)='Создать']/parent::*"));
            SleepSec(2);
            return this;
        }
        public HelperBase SubmitEndRefresh()
        {
            // нажать на кнопку создать
            Click(By.XPath("//*/text()[normalize-space(.)='Создать']/parent::*"));
            SleepSec(2);
            //обновить страницу
            wd.Navigate().Refresh();
            return this;
        }
        public void AgreementProcess(AccountDate account, string nameWindow)
        {
            // нажать на кнопку отправить на согласование
            Click(By.XPath("//*/text()[normalize-space(.)='Отправить на согласование']/parent::*"));
            SleepSec(3);
            //нажать на кнопку согласовать
            Click(By.XPath("//*/text()[normalize-space(.)='Согласовать']/parent::*"));
            //подписать эцп
            EZP(account, nameWindow);
            SleepSec(3);
            //обновить страницу
            wd.Navigate().Refresh();
        }
        public HelperBase EZP(AccountDate account, string nameWindow)
        {
            WaitWindow(nameWindow);
            InputSimulator sim = new InputSimulator();
            Thread.Sleep(500);
            sim.Keyboard.TextEntry(account.Userezp);
            Thread.Sleep(1000);
            // submit enter 
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            Thread.Sleep(1500);
            // Enter Password 
            sim.Keyboard.TextEntry(account.Password);
            // submit enter 
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            Thread.Sleep(1000);
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
            return this;
        }
        public HelperBase CompleteFormation()
        { // нажать на кнопку завершить формирование
            Click(By.XPath("//*/text()[normalize-space(.)='Завершить формирование']/parent::*"));
            return this;
        }
        public bool PresentDocumentSection()
        {// проверка наличия документа в разделе
            Click(By.XPath("//*/text()[normalize-space(.)='Развернуть']/parent::*"));
            SleepSec(2);
            return IsElementPresent(By.XPath("//tr[2]/td/div"), 0);
        }
        public HelperBase ApplyForKVE()
        { // нажать на кнопку подать заявку на КВЭ
            Click(By.XPath("//*/text()[normalize-space(.)='Подать заявку на КВЭ']/parent::*"));
            return this;
        }
        public HelperBase ZoomBrowser(string nameZoom, int numberСlicks)
        {
            
            return this;
        }
        public void SelectElementList(By by, String nameElement)
        {

            ICollection<IWebElement> elements = wd.FindElements(by);
            foreach (IWebElement element in elements)
            {
                if (String.Equals(element.GetAttribute("textContent"), nameElement))
                {
                    element.Click();
                }
                //Console.WriteLine(element.GetAttribute("textContent"));
            }
        }
        

    }
}