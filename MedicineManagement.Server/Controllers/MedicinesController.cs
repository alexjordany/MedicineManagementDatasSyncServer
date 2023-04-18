using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineManagement.Server.Models;
using Microsoft.AspNetCore.Datasync;
using Microsoft.AspNetCore.Datasync.EFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicineManagement.Server.Controllers;

[Route("tables/medicines")]
public class MedicinesController : TableController<Medicine>
{
    public MedicinesController(AppDbContext dbContext)
    {
        Repository = new EntityTableRepository<Medicine>(dbContext);
    }
}
