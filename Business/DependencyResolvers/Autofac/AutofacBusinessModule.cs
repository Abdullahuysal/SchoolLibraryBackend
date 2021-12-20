using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookManager>().As<IBookService>().SingleInstance();
            builder.RegisterType<EfBookDal>().As<IBookDal>().SingleInstance();
            builder.RegisterType<StudentManager>().As<IStudentService>().SingleInstance();
            builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();
            builder.RegisterType<BorrowedBookManager>().As<IBorrowedBookService>().SingleInstance();
            builder.RegisterType<EfBorrowedBookDal>().As<IBorrowedBookDal>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            


        }
    }
}
