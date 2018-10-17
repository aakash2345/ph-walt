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
    public class DivisionLocationController : ControllerBase
    {
        readonly DivisionsLocationsService _divisionsLocationService;
        public DivisionLocationController(DivisionsLocationsService divisionsLocationService)
        {
            this._divisionsLocationService = divisionsLocationService;
        }

        [HttpPost]
        [Route("GetDivisionLocation")]
        public ActionResult<List<DivisionsLocationOption>> GetDivisionLocation([FromBody] DivisionLoctionModel divisionLoctionModel)
        {
            return this._divisionsLocationService.GetDivisionLocation("507981", divisionLoctionModel.MasterId);
        }

        //[HttpGet]
        //[Route("GetDivisionLocation/{id1:int}/{id2:int}")]
        //public ActionResult<List<DivisionsLocationOption>> GetDivisionLocation(Int32 id1, Int32 id2)
        //{
        //    // "507981" "E45003344"
        //    return this._divisionsLocationService.GetDivisionLocation(id1.ToString(), id2.ToString());
        //}
    }
}