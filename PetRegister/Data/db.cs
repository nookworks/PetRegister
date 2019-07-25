using System;
using System.Collections.Generic;
using PetRegister.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using PetRegister.Data;

namespace PetRegister.Data
{
    public class db
    {
        private readonly ApplicationDbContext _dbase;

        public void Add_record(PetOwner petowner)
        {

        }
        public void getrecord()
        {
            _dbase.PetOwnerList;
        }
    } 

}
