﻿using RecruitmentSystemAPI.Models;
using RecruitmentSystemAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentSystemAPI.Repositories
{
    public class LabourerRepo
    {
        RecruitmentSystemContext _context;
        public LabourerRepo(RecruitmentSystemContext context)
        {
            _context = context;
        }

        public IQueryable<LabourerVM> GetLabourers()
        {
            return _context.Labourers.Select(l => new LabourerVM
            {
                Id = l.Id,
                FirstName = l.FirstName,
                LastName = l.LastName,
                PersonalId = l.PersonalId,
                City = l.City,
                Province = l.Province,
                Country = l.Country,
                Address = l.Address,
                Phone = l.Phone,
                IsActive = l.IsActive,
                QualityRating = l.QualityRating,
                SatefyRating = l.SatefyRating

            });
        }
        public LabourerVM GetLabourerById(int id)
        {
            return _context.Labourers.Where(l => l.Id == id).Select(l => new LabourerVM
            {
                Id = l.Id,
                FirstName = l.FirstName,
                LastName = l.LastName,
                PersonalId = l.PersonalId,
                City = l.City,
                Province = l.Province,
                Country = l.Country,
                Address = l.Address,
                Phone = l.Phone,
                IsActive = l.IsActive,
                QualityRating = l.QualityRating,
                SatefyRating = l.SatefyRating
            }).FirstOrDefault();
        }


        public void UpdateLabourer(LabourerVM labourerVM)
        {
            var labourer = _context.Labourers.FirstOrDefault(l => l.Id == labourerVM.Id);
            if (labourer == null) throw new KeyNotFoundException();
            labourer.FirstName = labourerVM.FirstName;
            labourer.LastName =  labourerVM.LastName;
            labourer.PersonalId = labourerVM.PersonalId;
            labourer.City =  labourerVM.City;
            labourer.Province = labourerVM.Province;
            labourer.Country =  labourerVM.Country;
            labourer.Address =  labourerVM.Address;
            labourer.Phone =  labourerVM.Phone;
            labourer.IsActive = labourerVM.IsActive;
            labourer.QualityRating = labourerVM.QualityRating;
            labourer.SatefyRating = labourerVM.SatefyRating;

            _context.Update(labourer);
            _context.SaveChanges();
        }
        public LabourerVM AddLabourer(LabourerVM labourerVM, string userId)
        {
            var labourer = new Labourer
            {
                UserId = userId,
                FirstName = labourerVM.FirstName,
                LastName = labourerVM.LastName,
                PersonalId = labourerVM.PersonalId,
                City = labourerVM.City,
                Province = labourerVM.Province,
                Country = labourerVM.Country,
                Address = labourerVM.Address,
                Phone = labourerVM.Phone,
                IsActive = labourerVM.IsActive,
                QualityRating = labourerVM.QualityRating,
                SatefyRating = labourerVM.SatefyRating
            };
            _context.Add(labourer);
            _context.SaveChanges();
            return labourerVM;
        }

        public int? GetUserLabourerId(string userId)
        {
            return _context.Labourers.Where(l => l.UserId == userId).FirstOrDefault()?.Id;
        }
    }
}
