using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_Haumova.Data.Interfaces;
using Shop_Haumova.Data.Models;
using Shop_Haumova.Data.ViewModell;
using System;
using System.Collections.Generic;
using System.IO;

namespace Shop_Haumova.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private IItems IAllItems;
        private ICategorys IAllCategorys;
        VMItems VMItems = new VMItems();

        public ItemsController(IItems IAllItems, ICategorys IAllCategorys, IHostingEnvironment hostingEnvironment) 
        {
            this.IAllItems = IAllItems;
            this.IAllCategorys = IAllCategorys;
            this.hostingEnvironment = hostingEnvironment;
        }

        public ViewResult List(int id = 0) 
        {
            ViewBag.Title = "Страница с предметами";
            VMItems.Items = IAllItems.AllItems;
            VMItems.Categorys = IAllCategorys.AllCategorys;
            VMItems.SelectCategory = id;
            return View(VMItems);
        }

        [HttpGet]
        public ViewResult Add() 
        {
            IEnumerable<Categorys> Categorys = IAllCategorys.AllCategorys;
            return View(Categorys);
        }

        [HttpPost]
        public RedirectResult Add(string name, string description, IFormFile files, float price, int idCategory) 
        {
            if (files != null) 
            {
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "img");
                var filePath = Path.Combine(uploads, files.FileName);
                files.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            Items newItems = new Items();
            newItems.Name = name;
            newItems.Description = description;
            newItems.Img = files.FileName;
            newItems.Price = Convert.ToInt32(price);
            newItems.Category = new Categorys() { Id = idCategory };

            int id = IAllItems.Add(newItems);
            return Redirect("/Items/Update?id=" + id);
        }
    }
}
