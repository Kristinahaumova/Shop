using Shop_Haumova.Data.Interfaces;
using Shop_Haumova.Data.Models;
using System.Collections.Generic;

namespace Shop_Haumova.Data.Mocks
{
    public class MockCategorys : ICategorys
    {
        public IEnumerable<Categorys> AllCategorys {
            get 
            {
                return new List<Categorys> 
                {
                    new Categorys() {
                        Id = 0,
                        Name = "Микроволновые печи",
                        Description = "Электронное устройство для тепловой обработки продуктов за счёт поглощения ими энергии электромагнитных колебаний сверхвысоких частот (микроволн)."
                    },
                    new Categorys() {
                        Id = 1,
                        Name = "Холодильники",
                        Description = "Устройство, поддерживающее низкую температуру в теплоизолированной камере."
                    },
                    new Categorys() {
                        Id = 2,
                        Name = "Электрочайники",
                        Description = "Бытовой электрический прибор для нагревания и кипячения питьевой воды, работающий на электроэнергии."
                    }
                };
            }
        }
    }
}
