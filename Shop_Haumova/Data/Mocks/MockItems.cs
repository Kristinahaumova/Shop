using Shop_Haumova.Data.Interfaces;
using Shop_Haumova.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop_Haumova.Data.Mocks
{
    public class MockItems : IItems
    {
        public ICategorys _category = new MockCategorys();
        public IEnumerable<Items> AllItems {
            get 
            {
                return new List<Items>()
                {
                    new Items() {
                        Id = 0,
                        Name = "Samsung MS23T5018AP/BW",
                        Description = "Микроволновая печь Samsung MS23T5018AP/BW с фронтальной панелью розового цвета станет стильной и надежной помощницей на вашей кухне. ",
                        Img = "https://c.dns-shop.ru/thumb/st4/fit/500/500/718bbe7b3b5cde4a1b24a32503b91d41/585040c3ff509530cc82284675ae55a87e41f3825943fdcf86d96673dd52607b.jpg.webp",
                        Price = 15999,
                        Category = _category.AllCategorys.Where(x => x.Id == 0).First()
                    },
                    new Items() {
                        Id = 1,
                        Name = "LEX LCD505PnGID",
                        Description = "Холодильник LEX LCD 505 станет отличным выбором для большой семьи и стильной кухни. Объем 505 литров позволит разместить все, чего вам захочется. ",
                        Img = "https://c.dns-shop.ru/thumb/st1/fit/500/500/5556a401d725b5424a8658bab6509a52/1fbf5c538939faf9891461e690bba630bd5f503fcdb135524938738517ba8020.jpg.webp",
                        Price = 111499,
                        Category = _category.AllCategorys.Where(x => x.Id == 1).First()
                    },
                    new Items() {
                        Id = 2,
                        Name = "Smeg KLF03PKEU",
                        Description = "Электрочайник Smeg KLF03PKEU станет не только функциональным, но и декоративным элементом вашей кухни благодаря выполненной в сдержанных розовых тонах расцветке.",
                        Img = "https://c.dns-shop.ru/thumb/st4/fit/500/500/bbef5d92ce6f5ceb17191dae8ebdc8d9/8a31fb9d0baf662f7298b672c70bd06408541a04e2b0f73b50f908072a00fc91.jpg.webp",
                        Price = 16399,
                        Category = _category.AllCategorys.Where(x => x.Id == 2).First()
                    }
                };
            }
        }
    }
}
