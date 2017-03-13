﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment7.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Community_AssistEntities : DbContext
    {
        public Community_AssistEntities()
            : base("name=Community_AssistEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<GrantRequest> GrantRequests { get; set; }
        public virtual DbSet<GrantReview> GrantReviews { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
    
        public virtual int usp_Register(string lastname, string firstname, string email, string password, string apartmentNumber, string street, string city, string state, string zipcode, string homePhone, string workPhone)
        {
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var apartmentNumberParameter = apartmentNumber != null ?
                new ObjectParameter("ApartmentNumber", apartmentNumber) :
                new ObjectParameter("ApartmentNumber", typeof(string));
    
            var streetParameter = street != null ?
                new ObjectParameter("Street", street) :
                new ObjectParameter("Street", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipcodeParameter = zipcode != null ?
                new ObjectParameter("Zipcode", zipcode) :
                new ObjectParameter("Zipcode", typeof(string));
    
            var homePhoneParameter = homePhone != null ?
                new ObjectParameter("HomePhone", homePhone) :
                new ObjectParameter("HomePhone", typeof(string));
    
            var workPhoneParameter = workPhone != null ?
                new ObjectParameter("WorkPhone", workPhone) :
                new ObjectParameter("WorkPhone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Register", lastnameParameter, firstnameParameter, emailParameter, passwordParameter, apartmentNumberParameter, streetParameter, cityParameter, stateParameter, zipcodeParameter, homePhoneParameter, workPhoneParameter);
        }
    }
}
