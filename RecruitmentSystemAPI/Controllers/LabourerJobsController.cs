﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecruitmentSystemAPI.Models;
using RecruitmentSystemAPI.Repositories;
using RecruitmentSystemAPI.ViewModels;

namespace RecruitmentSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class LabourerJobsController : ControllerBase
    {
        private readonly RecruitmentSystemContext _context;
        private readonly UserManager<SystemUser> _userManager;
        private readonly LabourerJobsRepo _labourerJobsRepo;

        public LabourerJobsController(RecruitmentSystemContext context, UserManager<SystemUser> userManager, LabourerJobsRepo labourerJobsRepo)
        {
            _context          = context;
            _userManager      = userManager;
            _labourerJobsRepo = labourerJobsRepo;
        }

        //GET: api/LabourerJobs/{jobId}
        // Return a list of labourers for a particular job in one company
        [HttpGet("{jobId}")]
        [Authorize(Roles = "Company")]
        public ActionResult<IEnumerable<JobLabourerVM>> GetJobLabourerList(int jobId)
        {
            //var company = _userManager.GetUserId(User);
            var result = _labourerJobsRepo.GetLabourersList(jobId);
            //if (result == null) return NotFound();
            return Ok(result);
        }

        // GET: api/LabourerJobs
        [HttpGet]
        [Authorize(Roles = "Labourer")]
        public ActionResult<IEnumerable<LabourerJobVM>> GetLabourerJobs(int count = 20, int page = 1, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var userId = _userManager.GetUserId(User);
            var result = _labourerJobsRepo.GetLabourerJobsByUserId(userId, count, page, fromDate, toDate);
            return Ok(result);
        }
                
        // POST: api/LabourerJobs
        [HttpPost]
        [Authorize(Roles = "Labourer")] //TODO: consider to remove the function, bc there is no option to add labourer's job from client
        public ActionResult<LabourerJobVM> PostLabourerJob([FromBody]LabourerJobVM labourerJobVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userId = _userManager.GetUserId(User);
                    var result = _labourerJobsRepo.AddLabourerJob(labourerJobVM, userId);
                    return Ok(result);
                }
                catch (Exception e)
                {
                    return StatusCode(500, new { message = e.Message });
                }
            }
            return BadRequest();
        }
        [HttpPut]
        [Route("UpdateJobRating")]
        [Authorize(Roles = "Labourer")]
        public ActionResult UpdateJobRating(int idToGrade, int rating)
        {
            try
            {
                var labourerJobsRepo = new LabourerJobsRepo(_context);
                
                var userId = _userManager.GetUserId(User);
                labourerJobsRepo.UpdateJobRating(idToGrade, rating, userId);
                return Ok();
            }
                catch (Exception e)
                {
                    return StatusCode(500, new { message = e.Message });
                }
        }
    }
}
