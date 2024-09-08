﻿using MagicVilla_VillaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    [ApiController]
    public class VillaAPIController : ControllerBase

    {
        [Route("api/VillaAPI")]
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
                {
                new Villa{Id=1,Name="Pool View" },
            new Villa{Id=2,Name="Beach View" }
            };
        }


    }
}
