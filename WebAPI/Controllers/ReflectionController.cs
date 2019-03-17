using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ReflectionController : ApiController
    {
        /// <summary>
        /// Check given string named class we have or not
        /// Using Reflection API
        /// runtime typechecking, dynamically creating instance of a class
        /// getting properties and invoking methods
        /// </summary>
        /// <returns>true or false</returns>
        //GET api/reflection/checkClass?className={name}
        [HttpGet]
        [ActionName("CheckClass")]
        public bool CheckClass(string className)
        {
            //since we are only getting classname as a parameter we have to check in every namespaces
            //retrieving all namespaces in the project
            var namespaces = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Select(t => t.Namespace)
                .Distinct();
            //looping through namespaces
            foreach(string s in namespaces) {
                //trying to build a type based on the given className and namespace
                Type T = Type.GetType(s + "." + className);
                if (T != null){
                    //yea we found our guy
                    MethodInfo tempMethodInfo = null;
                    //we can get all properties
                    foreach (PropertyInfo p in T.GetProperties())
                    {
                        System.Diagnostics.Debug.WriteLine(p.Name);
                    }

                    //we can get all methods
                    foreach (MethodInfo m in T.GetMethods())
                    {
                        tempMethodInfo = m;
                        System.Diagnostics.Debug.WriteLine(m.Name);
                    }
                    

                    if (tempMethodInfo != null)
                    {
                        //initializing class
                        object classInstance = Activator.CreateInstance(T, null);

                        ParameterInfo[] parameters = tempMethodInfo.GetParameters();
                        object[] parametersArray = new object[] { "TestHello" };
                        dynamic result = tempMethodInfo.Invoke(classInstance, parameters.Length == 0 ? null : parametersArray);

                    }

                    

                    return true;
                }
            }
            return false;
        }
    }
}
