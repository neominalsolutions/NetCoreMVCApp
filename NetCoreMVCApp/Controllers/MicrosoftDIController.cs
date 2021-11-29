using Microsoft.AspNetCore.Mvc;
using NetCoreMVCApp.DIServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.Controllers
{

    // https://stackoverflow.com/questions/39174989/how-to-register-multiple-implementations-of-the-same-interface-in-asp-net-core
    // Ninject gibi bir IOC yapısı kullanmayacaksak tercih edilebilir.
    public class MicrosoftDIController : Controller
    {
        private readonly ITransientService t1;
        private readonly TransientService t3;
        // BTransientService
        private readonly ITransientService t2;
        private readonly IScopeService s1;
        private readonly IScopeService s2;
        private readonly ISingletonService ss1;
        private readonly ISingletonService ss2;

        // scope service request web request bazlı tek instance çalışır
        // Application Service ve Repository service varsa (TaskManager) scope service  (disposable olması açısından, IO işelemleri)
        // Scope service Unmanagement resource
        // singleton uygulama bazlı tek instance (Helper işlemleri için. DateTimeHelper, StringHelper, ApplicationConfiig dosyaları static tanımlı tek instance ile çalışırsa daha performanslı kullanmış oluruz.)
        // transient ise her bir istek iç,in ayrı instance üretiyor
        // (Session ve Validation ve AuthorizationHandler için Transient kullanılır) Management Resource
        public MicrosoftDIController(ITransientService t1, ITransientService t2, IScopeService s1, IScopeService s2, ISingletonService ss1, ISingletonService ss2)
        {
            this.t1 = t1;
            this.t2 = t2;
            this.s1 = s1;
            this.s2 = s2;
            this.ss1 = ss1;
            this.ss2 = ss2;


           
        }

        public IActionResult Index()
        {
            ViewBag.T1 = t1.Id;
            ViewBag.T2 = t2.Id;
            ViewBag.S1 = s1.Id;
            ViewBag.S2 = s2.Id;
            ViewBag.SS1 = ss1.Id;
            ViewBag.SS2 = ss2.Id;

            return View();
        }
    }
}
