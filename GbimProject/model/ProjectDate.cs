using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebGbimTests
{ 
public class ProjectDate : IEquatable<ProjectDate> //функция сравнения
    {
    
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public ProjectDate(string projectCode, string nameRus, string nameKaz, string nameEng, string shortDescriptionRus, string shortDescriptionKaz, string shortDescriptionEng, string detailedDescriptionRus, string detailedDescriptionKaz, string detailedDescriptionEng, string sourceFinancing, string typeConstruction, string constructionObject)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    {
        ProjectCode = projectCode;
        NameRus = nameRus;
        NameKaz = nameKaz;
        NameEng = nameEng;
        ShortDescriptionRus = shortDescriptionRus;
        ShortDescriptionKaz = shortDescriptionKaz;
        ShortDescriptionEng = shortDescriptionEng;
        DetailedDescriptionRus = detailedDescriptionRus;
        DetailedDescriptionKaz = detailedDescriptionKaz;
        DetailedDescriptionEng = detailedDescriptionEng;
        SourceFinancing = sourceFinancing;
        TypeConstruction = typeConstruction;
        ConstructionObject = constructionObject;

    }

    public string NameRus { get; set; }
    public string NameKaz { get; set; }
    public string NameEng { get; set; }
    public string ShortDescriptionRus { get; set; }
    public string ShortDescriptionKaz { get; set; }
    public string ShortDescriptionEng { get; set; }
    public string DetailedDescriptionRus { get; set; }
    public string DetailedDescriptionKaz { get; set; }
    public string DetailedDescriptionEng { get; set; }
    public string SourceFinancing { get; set; }
    public string TypeConstruction { get; set; }
    public string ConstructionObject { get; set; }
    public string ProjectCode { get; set; }

#pragma warning disable CS8767 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).
        public bool Equals(ProjectDate other) //реализация сравнения nameRus
#pragma warning restore CS8767 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).
        {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        return NameRus == other.NameRus; //проверяются только имена 
        }
       // groupCache.Add(new GroupData(element.Text)
        //{ 
           // Id = element.FindElement(By.TagName("input")).GetAttribute("value")
       // }
        //);
}

}
