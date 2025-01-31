﻿using System;
using System.Linq;
using FindMyPet.Data;
using FindMyPet.Models;
using FindMyPet.Web.Models.BindingModels;
using FindMyPet.Web.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FindMyPet.Web.Admin.Pages.PetsPages
{
    [Area(StaticConstants.AdminRole)]
    [Authorize(Roles = StaticConstants.AdminRole)]
    public class DeleteModel : PageModel
    {

        public FindMyPetDbContext context { get; set; }

        public DeleteModel(FindMyPetDbContext context)
        {
            this.context = context;
        }


        public int Id { get; set; }

        [BindProperty]
        public string Type { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int? Age { get; set; }

        [BindProperty]
        public string ImageUrl { get; set; }

        [BindProperty]
        public string LocationLost { get; set; }

        [BindProperty]
        public DateTime TimeLost { get; set; }

        [BindProperty]
        public DateTime TimeFound { get; set; }

        [BindProperty]
        public string Gender { get; set; }

        [BindProperty]
        public string Breed { get; set; }

        [BindProperty]
        public string Color { get; set; }
        
        public IActionResult OnGet(int id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return Redirect(StaticConstants.LoginRedirect);
            }
            
                CreatePetBindingModel pet = context.Pets
                    .Select(p => new CreatePetBindingModel()
                    {
                        Id = p.Id,
                        Type = p.Type,
                        Name = p.Name,
                        Age = p.Age,
                        ImageUrl = p.ImageUrl,
                        LocationLost = p.LocationLost,
                        TimeLost = p.TimeLost,
                        Gender = p.Gender,
                        Breed = p.Breed,
                        Color = p.Color,
                    })
                    .FirstOrDefault(p => p.Id == id);

                if (pet == null)
                    return RedirectToAction(StaticConstants.All, StaticConstants.Pets);

                this.Id = pet.Id;
                this.Type = pet.Type;
                this.Name = pet.Name;
                this.Age = pet.Age;
                this.ImageUrl = pet.ImageUrl;
                this.LocationLost = pet.LocationLost;
                this.TimeLost = pet.TimeLost;
                this.Gender = pet.Gender;
                this.Breed = pet.Breed;
                this.Color = pet.Color;
            

            return Page();
        }
        
        public IActionResult OnPost(int id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return Redirect(StaticConstants.LoginRedirect);
            }

            
                Pet pet = context.Pets
                    .Include(p => p.Comments)
                    .ThenInclude(c => c.Likes)
                    .FirstOrDefault(p => p.Id == id);
                
                foreach (Comment comm in pet.Comments)
                {
                    foreach (Like like in comm.Likes)
                    {
                        context.Likes.Remove(like);
                    }

                    context.Comments.Remove(comm);
                }

                context.SaveChanges();
                
                if (pet == null)
                    return RedirectToAction(StaticConstants.All, StaticConstants.Pets);

                context.Pets.Remove(pet);
                context.SaveChanges();

                return RedirectToAction(StaticConstants.All, StaticConstants.AdminRole);      
        }
    }
}