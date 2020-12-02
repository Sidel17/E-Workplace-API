using AutoMapper;
using Co.Id.Moonlay.Simple.Auth.Service.Lib;
using Co.Id.Moonlay.Simple.Auth.Service.Lib.BusinessLogic.Interfaces;
using Co.Id.Moonlay.Simple.Auth.Service.Lib.Models;
using Co.Id.Moonlay.Simple.Auth.Service.Lib.Services.IdentityService;
using Co.Id.Moonlay.Simple.Auth.Service.Lib.Services.ValidateService;
using Co.Id.Moonlay.Simple.Auth.Service.Lib.ViewModels;
using Co.Id.Moonlay.Simple.Auth.Service.Lib.ViewModels.Forms;
using Com.Moonlay.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Co.Id.Moonlay.Simple.Auth.Service.WebApi.Controllers.v1
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/educationinfo")]
    [Authorize]
    public class EducationInfoController : Controller
    {
        private const string UserAgent = "auth-service";
        private readonly AuthDbContext _context;
        public static readonly string ApiVersion = "1.0.0";
        private readonly IIdentityService _identityService;
        private readonly IValidateService _validateService;

        public EducationInfoController(IIdentityService identityService, IValidateService validateService, AuthDbContext dbContext)
        {
            _identityService = identityService;
            _validateService = validateService;
            _context = dbContext;
        }

        protected void VerifyUser()
        {
            _identityService.Username = User.Claims.ToArray().SingleOrDefault(p => p.Type.Equals("username")).Value;
            _identityService.Token = Request.Headers["Authorization"].FirstOrDefault().Replace("Bearer ", "");
            _identityService.TimezoneOffset = Convert.ToInt32(Request.Headers["x-timezone-offset"]);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EducationInfo>>> GetEducationInfos()
        {
            return await _context.EducationInfos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EducationInfo>> GetEducationInfos(int id)
        {
            var educationInfo = await _context.EducationInfos.FindAsync(id);

            if (educationInfo == null)
            {
                return NotFound();
            }

            return educationInfo;
        }

        [HttpPost]
        public async Task<ActionResult<EducationInfo>> PostEducationInfos( [FromBody] EducationInfoFormViewModel educationInfo)
        {
            VerifyUser();
            var model = new EducationInfo()
            {
                EducationInfoId = educationInfo.EducationInfoId,
                Grade = educationInfo.Grade,
                Institution = educationInfo.Institution,
                Majors = educationInfo.Majors,
                YearStart = educationInfo.YearStart,
                YearEnd = educationInfo.YearEnd
            };
            EntityExtension.FlagForCreate(model, _identityService.Username, UserAgent);
            _context.EducationInfos.Add(model);
            await _context.SaveChangesAsync();
            return Created("", model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EducationInfo>> DeleteEducationInfo(int id)
        {
            VerifyUser();
            var educationInfo = await _context.EducationInfos.FindAsync(id);
            if (educationInfo == null)
            {
                return NotFound();
            }

            _context.EducationInfos.Remove(educationInfo);
            await _context.SaveChangesAsync();

            return educationInfo;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducationInfo(int id, [FromBody] EducationInfoFormViewModel educationInfo)
        {
            /*if (id != educationInfo.Id)
            {
                return BadRequest();
            }*/

            try
            {
                VerifyUser();
                var model = await _context.EducationInfos.FindAsync(id);
                {
                    model.Grade = educationInfo.Grade;
                    model.Majors = educationInfo.Majors;
                    model.Institution = educationInfo.Institution;
                    model.YearStart = educationInfo.YearStart;
                    model.YearEnd = educationInfo.YearEnd;
                };
                EntityExtension.FlagForUpdate(model, _identityService.Username, UserAgent);
                _context.EducationInfos.Update(model);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationInfoExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool EducationInfoExist(long id)
        {
            return _context.EducationInfos.Any(e => e.Id == id);
        }
    }
}
