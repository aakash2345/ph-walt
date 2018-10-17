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
    public class SupplierAddressController : ControllerBase
    {
        readonly SupplierService _supplierService;
        public SupplierAddressController(SupplierService supplierService)
        {
            this._supplierService = supplierService;
        }

        [HttpGet]
        [Route("Get/{id:int}")]
        public ActionResult<List<SupplierAddressOption>> Get()
        {
            return this._supplierService.GetSupplierAddress("058322400");
        }

        //[HttpGet]
        //[Route("GetAddress/{masterId:int}")]
        //public ActionResult<List<SupplierAddressOption>> GetAddress(Int32 masterId)
        //{
        //    //058322400
        //    return this._supplierService.GetSupplierAddress(masterId.ToString());
        //}
    }
}