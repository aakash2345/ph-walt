using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phc_Common_Api.Service;
using Phc_Common_Api.ViewModel;

namespace Phc_Common_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        readonly SupplierService _supplierService;
        public SupplierController(SupplierService supplierService)
        {
            this._supplierService = supplierService; 
        }

        [HttpGet]
        [Route("GetSuppliers/{id:int}")]
        public ActionResult<List<SupplierOption>> GetSuppliers(Int32 id)
        {
            // "507981"
            return this._supplierService.GetSupplier(id.ToString()); 
        }


    }
}