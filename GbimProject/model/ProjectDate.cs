using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGbimTests
{
     
    public class ProjectDate
    {
    private string projectCode;
    private string nameRus;
    private string nameKaz;
    private string nameEng;
    private string shortDescriptionRus;
    private string shortDescriptionKaz;
    private string shortDescriptionEng;
    private string detailedDescriptionRus;
    private string detailedDescriptionKaz;
    private string detailedDescriptionEng;
    private string sourceFinancing;
    private string typeConstruction; 
    private string constructionObject;

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public ProjectDate(string projectCode, string nameRus, string nameKaz, string nameEng, string shortDescriptionRus, string shortDescriptionKaz, string shortDescriptionEng, string detailedDescriptionRus, string detailedDescriptionKaz, string detailedDescriptionEng, string sourceFinancing, string typeConstruction, string constructionObject )
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            this.ProjectCode = projectCode;
            this.nameRus = nameRus;
            this.nameKaz = nameKaz;
            this.nameEng = nameEng;
            this.shortDescriptionRus = shortDescriptionRus;
            this.shortDescriptionKaz = shortDescriptionKaz;
            this.shortDescriptionEng = shortDescriptionEng;
            this.detailedDescriptionRus = detailedDescriptionRus;
            this.detailedDescriptionKaz = detailedDescriptionKaz;
            this.detailedDescriptionEng = detailedDescriptionEng;
            this.sourceFinancing = sourceFinancing;
            this.TypeConstruction = typeConstruction;
            this.ConstructionObject = constructionObject;
            
        }

        public string NameRus { get => nameRus; set => nameRus = value; }
        public string NameKaz { get => nameKaz; set => nameKaz = value; }
        public string NameEng { get => nameEng; set => nameEng = value; }
        public string ShortDescriptionRus { get => shortDescriptionRus; set => shortDescriptionRus = value; }
        public string ShortDescriptionKaz { get => shortDescriptionKaz; set => shortDescriptionKaz = value; }
        public string ShortDescriptionEng { get => shortDescriptionEng; set => shortDescriptionEng = value; }
        public string DetailedDescriptionRus { get => detailedDescriptionRus; set => detailedDescriptionRus = value; }
        public string DetailedDescriptionKaz { get => detailedDescriptionKaz; set => detailedDescriptionKaz = value; }
        public string DetailedDescriptionEng { get => detailedDescriptionEng; set => detailedDescriptionEng = value; }
        public string SourceFinancing { get => sourceFinancing; set => sourceFinancing = value; }
        public string TypeConstruction { get => typeConstruction; set => typeConstruction = value; }
        public string ConstructionObject { get => constructionObject; set => constructionObject = value; }
        public string ProjectCode { get => projectCode; set => projectCode = value; }
    }
}
