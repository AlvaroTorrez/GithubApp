using Autofac;
using GithubMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace GithubMobileApp
{
    public class DIRegister
    {
        private static DIRegister Instance { get; set; }

        static IContainer container;
        static readonly ContainerBuilder builder = new ContainerBuilder();

        private DIRegister()
        {
        }

        public static void RegisterDI()
        {
            GetDIRegister();


            RegisterDIViewModel();
        }

        public static void RegisterDIViewModel()
        {
            RegisterType<MainUserListViewModel>();
        }

        public static DIRegister GetDIRegister()
        {
            if (Instance == null)
            {
                Instance = new DIRegister();
            }
            return Instance;
        }

        public static void RegisterType<T>() where T : class
        {
            builder.RegisterType<T>();
        }

        public static void RegisterType<TInterface, T>() where TInterface : class where T : class, TInterface
        {
            builder.RegisterType<T>().As<TInterface>();
        }

        public static void RegisterTypeSingleto<TInterface, T>() where TInterface : class where T : class, TInterface
        {
            builder.RegisterType<T>().As<TInterface>().SingleInstance();
        }

        public static void BuildContainer()
        {
            container = builder.Build();
            DependencyResolver.ResolveUsing(type => container.IsRegistered(type) ? container.Resolve(type) : null);
        }
    }
}
