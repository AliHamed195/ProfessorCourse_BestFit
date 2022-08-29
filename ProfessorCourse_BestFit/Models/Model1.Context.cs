﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfessorCourse_BestFit.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProfessorCourseBestFitEntities : DbContext
    {
        public ProfessorCourseBestFitEntities()
            : base("name=ProfessorCourseBestFitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseKeyword> CourseKeywords { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Keyword> Keywords { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserCourse> UserCourses { get; set; }
        public virtual DbSet<UserDepartment> UserDepartments { get; set; }
        public virtual DbSet<UserKeyword> UserKeywords { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<spGetUserRoles_Result> spGetUserRoles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserRoles_Result>("spGetUserRoles");
        }
    
        public virtual ObjectResult<spGetUserRolesById_Result> spGetUserRolesById(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserRolesById_Result>("spGetUserRolesById", userIdParameter);
        }
    
        public virtual ObjectResult<string> my_InsertUpdateDelete_Course(Nullable<int> courseID, string courseCode, string courseName, Nullable<System.DateTime> courseDateStart, Nullable<int> courseDuration, Nullable<int> query)
        {
            var courseIDParameter = courseID.HasValue ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(int));
    
            var courseCodeParameter = courseCode != null ?
                new ObjectParameter("CourseCode", courseCode) :
                new ObjectParameter("CourseCode", typeof(string));
    
            var courseNameParameter = courseName != null ?
                new ObjectParameter("CourseName", courseName) :
                new ObjectParameter("CourseName", typeof(string));
    
            var courseDateStartParameter = courseDateStart.HasValue ?
                new ObjectParameter("CourseDateStart", courseDateStart) :
                new ObjectParameter("CourseDateStart", typeof(System.DateTime));
    
            var courseDurationParameter = courseDuration.HasValue ?
                new ObjectParameter("CourseDuration", courseDuration) :
                new ObjectParameter("CourseDuration", typeof(int));
    
            var queryParameter = query.HasValue ?
                new ObjectParameter("Query", query) :
                new ObjectParameter("Query", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("my_InsertUpdateDelete_Course", courseIDParameter, courseCodeParameter, courseNameParameter, courseDateStartParameter, courseDurationParameter, queryParameter);
        }
    
        public virtual ObjectResult<string> my_InsertUpdateDelete_Department(Nullable<int> departmentID, string departmentName, Nullable<int> userID, Nullable<int> query)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var queryParameter = query.HasValue ?
                new ObjectParameter("Query", query) :
                new ObjectParameter("Query", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("my_InsertUpdateDelete_Department", departmentIDParameter, departmentNameParameter, userIDParameter, queryParameter);
        }
    
        public virtual ObjectResult<string> my_InsertUpdateDelete_Program(Nullable<int> programID, string programName, Nullable<int> departmentID, Nullable<int> query)
        {
            var programIDParameter = programID.HasValue ?
                new ObjectParameter("ProgramID", programID) :
                new ObjectParameter("ProgramID", typeof(int));
    
            var programNameParameter = programName != null ?
                new ObjectParameter("ProgramName", programName) :
                new ObjectParameter("ProgramName", typeof(string));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var queryParameter = query.HasValue ?
                new ObjectParameter("Query", query) :
                new ObjectParameter("Query", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("my_InsertUpdateDelete_Program", programIDParameter, programNameParameter, departmentIDParameter, queryParameter);
        }
    
        public virtual ObjectResult<JoinuserAndUserRole_Result> JoinuserAndUserRole()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JoinuserAndUserRole_Result>("JoinuserAndUserRole");
        }
    }
}
